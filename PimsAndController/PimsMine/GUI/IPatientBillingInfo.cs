using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS
{
    interface IPatientBillingInfo
    {
        decimal charges { get; set; }
        decimal amtPaid { get; set; }
        decimal amtOwed { get; set; }
        decimal insPaid { get; set; }
        string billAddress { get; set; }
        DateTime dueDate { get; set; }

    }
}
