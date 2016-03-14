using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class CurUser
    {
        User current { get; set; }

        Patient getInfo()
        {
            Patient myPatient;
            myPatient = current.getPatient();
            return myPatient;
        }
    }
}
