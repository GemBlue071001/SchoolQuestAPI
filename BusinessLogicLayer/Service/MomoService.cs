using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel.Momo;
using DataAccessLayer.UnitOfWork;
using Domain.Models;
using MailKit.Net.Smtp;
using MimeKit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace BusinessLogicLayer.Service
{
    public class MomoService : IMomoService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public MomoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<string> CreatePayment(string token, OrderRequestModel orderModel)
        {
            JsonSerializerSettings jsonSerializerSettings = new()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            //conver order model self config to base64string
            var orderJsonStringRaw = JsonConvert.SerializeObject(orderModel, Formatting.Indented,
                jsonSerializerSettings);
            var orderTextBytes = System.Text.Encoding.UTF8.GetBytes(orderJsonStringRaw);
            var base64OrderString = Convert.ToBase64String(orderTextBytes);

            string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
            string partnerCode = "MOMOFH0Y20221003";
            string accessKey = "YAX7OxslhYkTXzbK";
            string serectkey = "jrQjul5BxdOMI7kHvIYAWCka1XIXXF7M";
            string orderInfo = "test";
            string redirectUrl = "https://www.youtube.com/watch?v=SXDJ1bGTJ_U"; //Sau khi thanh toan xong, trang QR  code cua momo se redirect ve trang ma minh config
            string ipnUrl = "https://highschoolquestapi.onrender.com/api/Payment/ReceiveResponse"; // Sau khi quet QR thanh toan, momo se goi den api cua server minh, ipnUrl do minh config
            string requestType = "captureWallet";
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = base64OrderString; //extraData is orderModel or anything we want momo return after scan QR code

            var amountPay = 0.0;

            if (orderModel != null)
            {
                amountPay = orderModel.TotalPay;
            }
            //Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amountPay.ToString() +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType;

            string signatureRawHash = "accessKey=" + accessKey +
               "&orderId=" + orderId +
               "&partnerCode=" + partnerCode +
                "&requestId=" + requestId;

            MomoSecurity crypto = new MomoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);
            Console.Write("Signature = " + signature);
            string querySignature = crypto.signSHA256(rawHash, serectkey);
            Console.Write("QuerySignature = " + querySignature);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amountPay.ToString() },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };
            //Console.Write("Json request to MoMo: " + message.ToString());
            try
            {
                string responseFromMomo = await Task.FromResult(PaymentRequest.sendPaymentRequest(endpoint, message.ToString()));
                return responseFromMomo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<OrderRequestModel?> ReceiveResponse(MomoResponseModel moMoResponseModel)
        {
            try
            {
                var base64OrderBytes = Convert.FromBase64String(moMoResponseModel.extraData ?? "");
                var orderJson = System.Text.Encoding.UTF8.GetString(base64OrderBytes);
                var orderModel = new OrderRequestModel();
                orderModel = JsonConvert.DeserializeObject<OrderRequestModel>(orderJson);
                await _unitOfWork.Transactions.AddAsync(new Transaction
                {
                    Status = "Success",
                    TotalPay = (int)orderModel!.TotalPay,
                    TransactionDate = DateTime.UtcNow,
                    UserId = (Guid)orderModel.UserId!,
                });
                var user = await _unitOfWork.Users.GetAsync(x => x.Id == (Guid)orderModel.UserId!);
                user.GameToken += (((int)orderModel!.TotalPay) / 1000);

                await _unitOfWork.SaveChangeAsync();


                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("healthsystemcare", "healthsystemcare0@gmail.com"));
                message.To.Add(new MailboxAddress("", "trinhtam2001@gmail.com"));
                message.Subject = "thành công !!";
                var bodyBuilder = new BodyBuilder();

                bodyBuilder.HtmlBody = orderModel.ToString();

                message.Body = bodyBuilder.ToMessageBody();
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 465, true);
                    await client.AuthenticateAsync("trinhtam2001@gmail.com", "srtb iprw hiwv htpj");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                return (orderModel);
            }
            catch (Exception e)
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("healthsystemcare", "healthsystemcare0@gmail.com"));
                message.To.Add(new MailboxAddress("", "trinhtam2001@gmail.com"));
                message.Subject = "hello !!";
                var bodyBuilder = new BodyBuilder();

                bodyBuilder.HtmlBody = e.Message + e.InnerException.Message + e.ToString();

                message.Body = bodyBuilder.ToMessageBody();
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 465, true);
                    await client.AuthenticateAsync("trinhtam2001@gmail.com", "srtb iprw hiwv htpj");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                return null;
            }
        }
    }
}
