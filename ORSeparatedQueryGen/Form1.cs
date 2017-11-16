using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OrSeparatedQueryGen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void brnGenerate_Click(object sender, EventArgs e)
        {
            txtDest.Text = "";
            String Result;
            if (txtSource.Text == "")
            {
                txtDest.Text = "No IDs available to generate 'OR' separeted query!";
            }
            if (ValidateInput())
            {
                Result = "";
                foreach (String line in txtSource.Lines)
                {
                    Result += line.Trim() + " OR ";
                }
                if (Result.Length > 0)
                {
                    Result = Result.Substring(0, Result.Length - 8);
                    txtDest.Text = Result;
                }
                else
                {
                    txtDest.Text = "After deleting text entries,No IDs available to generate 'OR' separeted query!";
                }
            }
        }

        private bool ValidateInput()
        {
            String Result="";
            long num;
            bool res;
            foreach (String line in txtSource.Lines)
            {
                if( !(line.Trim() == ""))
                {
                    res = long.TryParse(line, out num);
                    if (res)
                    {
                        Result += line.Trim() + Environment.NewLine;
                    }
                }
            }
            txtSource.Text = Result;
            return true;
        }

        private void btnCpy_Click(object sender, EventArgs e)
        {
            
            if (!(txtDest.Text == ""))
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(txtDest.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong happened while copying to clipboard. Please use manual CTRL+C to copy.");
                }
            }
        }

        private void btnClearSrc_Click(object sender, EventArgs e)
        {
            txtSource.Text = "";
        }

        private void btnDestClear_Click(object sender, EventArgs e)
        {
            txtDest.Text = "";
        }

        private void btnGenerateList_Click(object sender, EventArgs e)
        {
            txtSource.Text = "";
            if (txtDest.Text != "")
            {
              String[] Temp;
                String TempStr;
              //String[] a = new String[] { "OR" };
              Temp = txtDest.Text.ToUpper().Split(new string[] { "OR" }, StringSplitOptions.None);
              if (Temp.Length == 0)
              {
                  txtSource.Text = "List cannot be generated as no valid query found.";
              }
              else
              {
                  TempStr="";
                  foreach (String elm in Temp)
                  {
                      TempStr += elm.Trim() + Environment.NewLine;
                  }
                  //TempStr = String.Join(Environment.NewLine, Temp);
                  txtSource.Text = TempStr;
              }
                  
            }
            else
            {
                txtSource.Text = "NO 'OR' Separated Query Found!";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(txtSource.Text == ""))
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(txtSource.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong happened while copying to clipboard. Please use manual CTRL+C to copy.");
                }
            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            txtDest.Text = "";
            String Result;
            if (txtSource.Text == "")
            {
                txtDest.Text = "No IDs available to generate 'OR' separeted query!";
            }
            if (ValidateInput())
            {
                Result = "";
                foreach (String line in txtSource.Lines)
                {
                    Result += line.Trim() + ", ";
                }
                if (Result.Length > 0)
                {
                    Result = Result.Substring(0, Result.Length - 4);
                    txtDest.Text = Result;
                }
                else
                {
                    txtDest.Text = "After deleting text entries,No IDs available to generate 'OR' separeted query!";
                }
            }
        }

    }
}
