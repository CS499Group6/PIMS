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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        //performs on opening of form2
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //executes when file is pressed in menue bar
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //executes when exit is pressed in menue bar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*Query Box for main menue::
        This code should ToUpper all inputs,
        then recognize the format of the search,
        ex: JOH,DOE is a vailid patient query.
        based on permissions should only display a valid screen
        for the operator.
        */
        private void queryBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        //query label
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lastNameQuery = queryTextBox.Text.ToUpper();

            //Open MainGrid
            if (PimsMain.Program.currentUser is PIMSController.Volunteer)
            {
                volunteerGrid volGrid = new volunteerGrid(lastNameQuery);
                volGrid.Visible = true;
                this.Hide();
            }
            else if (PimsMain.Program.currentUser is PIMSController.Doctor ||
                    PimsMain.Program.currentUser is PIMSController.MedStaff ||
                    PimsMain.Program.currentUser is PIMSController.OfficeStaff)
            {
                mainGrid MainGrid = new mainGrid(lastNameQuery);
                MainGrid.Visible = true;
                //Hide mainForm
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User! Closing Program",
                        "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
