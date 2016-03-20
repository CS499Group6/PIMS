using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS
{
    interface IInsInfo
    {
        string carrier { get; set; }
        string acctNum { get; set; }
        string groupNum { get; set; }

    }
}
