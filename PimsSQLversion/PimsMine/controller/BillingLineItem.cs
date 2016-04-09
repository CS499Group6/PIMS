using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class BillingLineItem
    {
        public string item { get; set; }
        public int cost { get; set; }
        public int paid { get; set; }
        public int insPaid { get; set; }
        public int owed { get; set; }
        public DateTime dueDate { get; set; }
        public string itemId;

    }
}
