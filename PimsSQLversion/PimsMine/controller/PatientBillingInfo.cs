using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class PatientBillingInfo
    {
        public List<BillingLineItem> items { get; set; }
        public PatientInsInfo insurance { get; set; }
        public string strAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public bool sameAsHome { get; set; }

        public PatientBillingInfo()
        {
            items = new List<BillingLineItem>();
            insurance = new PatientInsInfo();
            sameAsHome = true;

        }
    }
}
