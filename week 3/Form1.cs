using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnWhatStatus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCredits.Text, out double credits))
            {
                //  figure out status here
                if (credits>= 12)
                {
                    lblStatus.Text = "Full Time"; // figuring out full time students 
                }
              else if(credits >= 6)
                {
                    lblStatus.Text = "Half time"; // figuring out part time students
                }
                else if (credits >= 0)
                {
                    lblStatus.Text = "Less than Half time";
                }
               
            }
            else
            {
                MessageBox.Show("Enter a positive number", "Error");
            }
        }

    }
}









       
       