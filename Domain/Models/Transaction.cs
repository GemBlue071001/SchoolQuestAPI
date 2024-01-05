using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TotalPay { get; set; }
        public string Status {  get; set; } = string.Empty;
        public string? Description{ get; set; } = string.Empty;


        // 
        public User User { get; set; }
        public Guid UserId { get; set; }

    }
}
