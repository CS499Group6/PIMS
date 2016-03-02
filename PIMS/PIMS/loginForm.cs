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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        //this code will execute when the form 1 is loaded
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //this code is for the menue bar executes when "File" is clicked
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //This code is for the Exit button under the menue bar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*This code executes when the "Login" button is pressed
        when pressed transitions to main form(form2).

        Needs to interface with the database
        ex: check employee id and password match inputs from text box
        */
        private void button1_Click(object sender, EventArgs e)
        {
            //Open MainForm
            mainForm MainForm = new mainForm();
            MainForm.Visible = true;
            //Hide loginForm
            this.Hide();    
        }
        //This code is for the Password section
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Ths code is for the Username Section
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //label for password
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //label for username
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
