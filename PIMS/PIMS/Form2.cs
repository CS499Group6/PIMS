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
            this.Close();
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
            String lastNameQuery = queryTextBox.Text;

            //opens form3
            patientForm FM3 = new patientForm(lastNameQuery);
            FM3.Visible = true;
            //hides login screnn
            this.Hide();
        }
    }
}
