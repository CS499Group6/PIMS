using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIMSController
{
    public partial class PrintInfo
    {
        private Font printFont;
        private StreamReader streamToPrint;
        public string PrinterName { get; set; }
        [System.ComponentModel.BrowsableAttribute(true)]
        public PrinterSettings PrinterSettings { get; set; }
        private PrintDialog dialog = new PrintDialog();

        // The Click event is raised when the user clicks the Print button.
        public void printButton_Click()
        {


            dialog.AllowSomePages = true;
            dialog.ShowNetwork = true;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    streamToPrint = new StreamReader("MyFile.txt");
                    try
                    {
                        printFont = new Font("Courier New", 10);
                        PrintDocument pd = new PrintDocument();
                        pd.PrinterSettings.PrinterName = dialog.PrinterSettings.PrinterName;
                        dialog.Document = pd;
                        dialog.Document.PrintPage += new PrintPageEventHandler(pd_PrintPage);

                        pd.Print();
                    }
                    finally
                    {
                        streamToPrint.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

    }
}