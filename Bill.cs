using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemensCloset
{
    internal class Bill
    {
        public string billId { get; set; }
        public string sellerName { get; set; }
        public DateTime sellDate { get; set; }
        public decimal totalAmount { get; set; }

        public Bill(string billId, string sellerName, DateTime sellDate, decimal totalAmount)
        {
            this.billId = billId;
            this.sellerName = sellerName;
            this.sellDate = sellDate;
            this.totalAmount = totalAmount;
        }
    }
}
