using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModel.Momo
{
    public class OrderRequestModel
    {
        public double TotalPay { get; set; }
        public Guid? UserId { get; set; }

    }
}
