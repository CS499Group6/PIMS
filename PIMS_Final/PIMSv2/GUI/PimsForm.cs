using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class PimsForm : Form
    {
        // Default Constructor
        public PimsForm()
        {
            InitializeComponent();


            // Add LoginLeftSideButtons to Panel1
            splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            // Add Login form to Panel2
            splitContainer1.Panel2.Controls.Add(new Login());
        }

        // Will check to se if there is a currentPatient
        // If there is one, add the leftSideButtons to Panel1
        public void checkCurrentPatient()
        {
            if (Program.currentPatient == null)
            {
                // Do nothing
                Console.WriteLine("cur patient is null");
            }
            else
            {
                // Add leftSideButton to Panel1
                this.splitContainer1.Panel1.Controls.Add(Program.leftSideButton);
            }
        }
    }
}
