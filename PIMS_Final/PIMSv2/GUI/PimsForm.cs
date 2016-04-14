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
        public PimsForm()
        {
            InitializeComponent();

            // Add Login form to Panel2
            splitContainer1.Panel2.Controls.Add(new Login());
            menuStrip1.Enabled = true;
            
            // Remove application minimize, maximize, and close box
            //this.ControlBox = false;
        }

        // Will check to se if there is a currentPatient
        // If there is one, add the leftSideButtons to Panel1
        public void checkCurrentPatient()
        {
            if(Program.currentPatient == null)
            {
                //do nothing
                Console.WriteLine("cur patient is null");
            }
            else
            {
                // Add leftSideButton to Panel1
                this.splitContainer1.Panel1.Controls.Add(Program.leftSideButton);
            }
        }

        // Will log the current user off the server
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;
            Program.currentUser = null;

            // Clear contents of Panel1 and Panel2
            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel2.Controls.Clear();
            // Add Login form to Panel2
            splitContainer1.Panel2.Controls.Add(new Login());
        }

        // Will exit the application
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
