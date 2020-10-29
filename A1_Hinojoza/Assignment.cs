using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_Hinojoza
{
    public partial class Assignment : Form
    {
        //program sees if student is elible for honors
        //Stores user name and tells them their eligibility
        public Assignment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }
        private void btnHonors_Click(object sender, EventArgs e)
        {
            double gpa;

            try
            {
                gpa = Convert.ToSingle(txtGPA.Text);
                lblMessage.Text = "";

                if (gpa <= 0 || gpa > 4)
                {
                    MessageBox.Show("Please enter a valid GPA", "Invalid GPA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (gpa >= 3.75)
                {
                    lblMessage.Text = "HONORS STUDENT";
                    MessageBox.Show("Congratulations " + txtFirstName.Text.ToUpper
                    () +
                                            "!! You will graduate with honors.",
                    "HONORS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else // No Honors
                {
                    MessageBox.Show("Sorry ­ No honors for you ­ better luck next time", "No Honors");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
