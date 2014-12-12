using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativeCashDraw.Controllers;
using System.IO;


namespace CreativeCashDraw.View
{
    public partial class CashDrawView : Form
    {
        public CashDrawView()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Allows the user to select the location of a cash file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOpenCashFile_Click(object sender, EventArgs e)
        {
            //ASR 12/12/2014    Configure the file dialog box.
            ofdCashFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdCashFile.FilterIndex = 2;
            ofdCashFile.RestoreDirectory = true;


            //ASR 12/12/2014    Open the dialog box
            if (ofdCashFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtCashFile.Text = ofdCashFile.FileName;
                    txtOutput.Text = Path.GetDirectoryName(ofdCashFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening the cash file: " + ex.Message);
                }
            }

        }



        /// <summary>
        /// Validates the form so that the Start button is activated when appropriate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCashFile_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }



        /// <summary>
        /// Determine if all over the required UI controls have been completed.
        /// </summary>
        private void ValidateForm()
        {
            StringBuilder errorList = new StringBuilder();


            //ASR 12/12/2014    Check if text box for file name is completed.
            if (txtCashFile.Text.Length == 0)
                errorList.AppendLine("No cash file selected");



            //ASR 12/12/2014    After validation is complete, enable start button if appropriate.
            if(errorList.ToString().Length == 0)
            {
                //ASR 12/12/2014    Enable start button.
                cmdStartProcess.Enabled = true;
            }
            else
            {
                //ASR 12/12/2014
                cmdStartProcess.Enabled = false;


                //ASR 12/12/2014.  The list of errors are available to display if necessary.  This
                //                  is added to faciliate future growth of the application, it is not
                //                  needed for this sample.
            }
        }



        /// <summary>
        /// Start the Cash Draw change-making process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStartProcess_Click(object sender, EventArgs e)
        {
            try
            {
                //ASR 12/12/2014    Initiated the cash draw object, passing the location of the cash file.
                CashDraw cashDraw = new CashDraw(txtCashFile.Text, txtOutput.Text);


                
                //ASR 12/12/2014    Start the change making process via the CashDraw object.
                cashDraw.Index();



                //ASR 12/12/2014    Notify process is complete.
                MessageBox.Show("Complete.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error making change " + ex.Message);
            }

        }
    }
}
