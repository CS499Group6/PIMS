using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class BillingGrid : UserControl
    {
        PIMSController.Patient patient;

        public BillingGrid()
        {
            InitializeComponent();

            patient = Program.currentPatient;

            int costSum = 0;
            int insPaidSum = 0;
            int paidSum = 0;
            int owedSum = 0;

            foreach (PIMSController.BillingLineItem item in patient.billing.items)
            {
                int owed = item.cost - item.insPaid - item.paid;
                owedSum += owed;
                costSum += item.cost;
                insPaidSum += item.insPaid;
                paidSum += item.paid;
                billingGridDataView.Rows.Add(item.item,
                             item.dueDate.ToString(@"MM\/dd\/yyyy"),
                             Math.Round(((float)item.cost / 100.0), 2),
                             Math.Round(((float)item.insPaid / 100.0), 2),
                             Math.Round(((float)item.paid / 100.0), 2),
                             Math.Round(((float)owed / 100.0), 2));
            }

        }
    }
}
