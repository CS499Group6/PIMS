using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class PatientBillingInfo
    {
        BillingLineItem[] items { get; set; }
        PatientInsInfo insurance { get; set; }
        string strAddress { get; set; }
        string city { get; set; }
        string state { get; set; }
        string zip { get; set; }
        bool sameAsHome { get; set; }

        PatientBillingInfo(PatientDirInfo curPatient)
        {
            items = new BillingLineItem[20];
            insurance = new PatientInsInfo();
            sameAsHome = true;
            if(!sameAsHome)
            {
                strAddress = "";
                city = "";
                state = "";
                zip = "";
            }
            else
            {
                strAddress = curPatient.strAddress;
                city = curPatient.city;
                state = curPatient.state;
                zip = curPatient.zip;
            }
        }

    }
}
