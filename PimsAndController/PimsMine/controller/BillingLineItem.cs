using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class BillingLineItem
    {
        string item { get; set; }
        int cost { get; set; }
        int paid { get; set; }
        int insPaid { get; set; }
        int owed { get; set; }
        DateTime dueDate { get; set; }

    }
}
