using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ---Patient query form----
The purpose for this form is for doctors, 
nurses and office staff to select a 
patient afer a search from the query box */
namespace PIMS
{
    public partial class mainGrid : Form
    {
        public mainGrid(String lastNameQuery)
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("Test.txt");

            String lastName = file.ReadLine();
            String tmpLastName = lastName.ToUpper();

            while (lastName != lastNameQuery)
            {
                if (tmpLastName == lastNameQuery)
                {
                    String firstName = file.ReadLine();
                    String middleName = file.ReadLine();
                    String dateOfBirth = file.ReadLine();

                    patientQueryDataGridView.Rows.Add("");
                    patientQueryDataGridView.Rows.Add(lastName);
                    patientQueryDataGridView.Rows.Add(firstName);
                    patientQueryDataGridView.Rows.Add(middleName);
                    patientQueryDataGridView.Rows.Add(dateOfBirth);

                    break;
                }

                Console.WriteLine(lastName);

                if (tmpLastName == null)
                {
                    Console.WriteLine("tmpLastName Not Found!");
                    MessageBox.Show("Patient not found in database! \n Please search for a new patient",
                        "Patient not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                lastName = file.ReadLine();
                tmpLastName = lastName.ToUpper();
            }

            file.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
