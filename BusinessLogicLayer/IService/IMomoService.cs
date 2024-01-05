using BusinessLogicLayer.RequestModel.Momo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IMomoService
    {
        public Task<string> CreatePayment(string token, OrderRequestModel orderModel);
        public Task<OrderRequestModel?> ReceiveResponse(MomoResponseModel moMoResponseModel);
    }
}
