using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EasyBilling.BLL
{
    class TransactionsBLL
    {
        public int id { get; set; }
        public string type { get; set; }
        public int dealer_customer_id { get; set; }
        public double grandTotal { get; set; }
        public DateTime transaction_date { get; set; }
        public double tax { get; set; }
        public double discount { get; set; }
        public int added_by { get; set; }
        public DataTable transactionDetails { get; set; }
    }
}
