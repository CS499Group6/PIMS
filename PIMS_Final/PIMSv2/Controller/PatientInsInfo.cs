using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class PatientInsInfo
    {
        public string provider { get; set; }
        public string bin { get; set; }
        public string id { get; set; }
        public string pcn { get; set; }
        public string groupNum { get; set; }
        public string insuranceType { get; set; }

        public PatientInsInfo()
        {
            provider = "1234567";
            bin = "1234567";
            id = "1234567";
            pcn = "1234567";
            groupNum = "1234567";
        }
    }
}
