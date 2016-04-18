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
    public partial class RoomAssignmentGrid : UserControl
    {
        // Default Constructor
        public RoomAssignmentGrid()
        {
            InitializeComponent();

            // Do not allow users to add new rows to roomAssignmentDataGridView
            roomAssignmentDataGridView.AllowUserToAddRows = false;
           
            //fill grid
            fill();
        }

        public void fill()
        {
            //create list
            List<PIMSController.HospLocation> hosplist = new List<PIMSController.HospLocation>();

            for(int i=1; i<26; i++)
            {
                hosplist.Add(PIMSController.SQLcommands.buildHospital(i));
            }   

            foreach (PIMSController.HospLocation bed in hosplist)
            {

                roomAssignmentDataGridView.Rows.Add(          
                   bed.unit,
                   bed.floor,
                   bed.roomNum,
                   bed.bedNum,
                   Convert.ToBoolean(bed.occupancy) ? "N" : "Y",
                   Convert.ToBoolean(bed.occupancy)? select.ReadOnly=false:select.ReadOnly=true);
               
            }            

        }

        private void roomAssignmentDataGridView_RowsAdded(){
            
        }

        // If the resultsDataGridView is clicked
        // Commit that edit
        private void roomAssignmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             var senderGrid = (DataGridView)sender;

                //if sender is from the button column and is not the header row execute commands
              if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                  e.RowIndex >= 0)
              {
                   if (Program.currentPatient != null)
                     {
                        foreach (DataGridViewRow row in roomAssignmentDataGridView.Rows)
                        {
                            if (row.Selected)
                            {
                                Program.currentPatient.directory.location.bedNum = Int32.Parse(row.Cells[3].Value.ToString());
                                Program.currentPatient.directory.location.roomNum = Int32.Parse(row.Cells[2].Value.ToString());
                                Program.currentPatient.directory.location.unit = row.Cells[0].Value.ToString();
                            }
                        }

                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add PatientSearch to Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new LocationForm());
                    }
            }


        }

    

    }//end class
}//end namespace

