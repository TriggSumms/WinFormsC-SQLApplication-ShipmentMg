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
    public partial class ContainerListings : Form
    {

        //private readonly InterviewRedemptionEntities2 interviewRedemptionEntities2;
        private readonly InterviewRedemptionEntities2 _db;

        public ContainerListings()
        {
            InitializeComponent();
           _db = new InterviewRedemptionEntities2();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'interviewRedemptionDataSet1.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.interviewRedemptionDataSet1.Shipment);
            // TODO: This line of code loads data into the 'interviewRedemptionDataSet.Container' table. You can move, or remove it, as needed.
            this.containerTableAdapter.Fill(this.interviewRedemptionDataSet.Container);

            var containers = _db.Containers.ToList();
            containerList.DataSource = containers;
            containerList.Columns[0].HeaderText = "ID";
            containerList.Columns[1].HeaderText = "NAME";
            //containerList.Columns[3].HeaderText = "Shipment";

            var shipments = _db.Shipments.ToList();
            shipmentList.DataSource = shipments;
            shipmentList.Columns[0].HeaderText = "ID";
            shipmentList.Columns[1].HeaderText = "NAME";
            //shipmentList.Columns[3].HeaderText = "PropertyId";

            //cbPropertySelection.DataSource = propertys;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var propertys = _db.Containers.ToList();
           //ContainerList.Columns[0].HeaderText = "ID";
           // ContainerList.Columns[1].HeaderText = "NAME";
            
            //cbPropertySelection.DataSource = propertys;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.containerTableAdapter.FillBy(this.interviewRedemptionDataSet.Container);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shipmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}