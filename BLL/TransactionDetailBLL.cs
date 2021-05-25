using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyBilling.BLL
{
    class TransactionDetailBLL
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public double rate { get; set; }
        public double qty { get; set; }
        public double total { get; set; }
        public int dealer_customer_id { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
        public int tranId { get; set; }
    }
}
