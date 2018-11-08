using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;

namespace SignUpForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Boolean isEmail()
        {
            if (Regex.IsMatch(emailBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void submitBox_Click(object sender, EventArgs e)
        {

            Boolean isValid = false;

            if (nameBox.Text != "" && addressBox.Text != "" && emailBox.Text != "" && phoneBox.Text != "")
            {
                if (isEmail())
                {
                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Invalid Emailid");
                }

            }
            else
            {
                MessageBox.Show("Fields Are Empty");
            }

            if (isValid)
            {

                string query = "INSERT INTO tblEmployee (EmployeeName,EmployeePhone,EmployeeEmail,EmployeeAddress) VALUES('" + nameBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "','" + addressBox.Text + "')";

                SampleConnection sampleConnection = new SampleConnection();

                sampleConnection.ExecuteNonQuery(query);
                nameBox.Text = "";
                addressBox.Text = "";
                phoneBox.Text = "";
                emailBox.Text = "";
                MessageBox.Show("Submitted Successfuly!!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

    
