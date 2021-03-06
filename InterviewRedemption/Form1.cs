using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewRedemption
{
    public partial class Form1 : Form
    {
        private readonly InterviewRedemptionEntities1 interviewRedemptionEntities1;
        public Form1()
       
        {
            ////Inititalizing my Db and creating the instance 
            InitializeComponent();
            interviewRedemptionEntities1 = new InterviewRedemptionEntities1();
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show($"Please Wait while we get ya over there: {tbEmployeeName.Text}");
                string employeeName = tbEmployeeName.Text;
                //string date = dtDate.Value.ToString();
                //var propertyName = cbPropertySelection.SelectedItem.ToString();
                var propertyName = cbPropertySelection.Text;
                //double cost = Convert.ToDouble(tbCost.Text);
                var isValid = true;
                var errorMessage = "";


                if (string.IsNullOrWhiteSpace(employeeName) || string.IsNullOrWhiteSpace(propertyName))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter your information to proceed";
                }

                if (isValid)
                {
                    MessageBox.Show($"Please Wait while we get ya over to {propertyName}\n\r" + $": Mr./Mrs: {employeeName}");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Select * from Propertys
            var propertys = interviewRedemptionEntities1.Propertys.ToList();
            cbPropertySelection.DisplayMember = "Name";
            cbPropertySelection.ValueMember = "id";
            cbPropertySelection.DataSource = propertys;
        }
    }
}
