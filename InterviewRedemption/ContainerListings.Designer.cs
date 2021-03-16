
namespace InterviewRedemption
{
    partial class ContainerListings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interviewRedemptionDataSet = new InterviewRedemption.InterviewRedemptionDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.containerTableAdapter = new InterviewRedemption.InterviewRedemptionDataSetTableAdapters.ContainerTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.containerList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interviewRedemptionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interviewRedemptionDataSet1 = new InterviewRedemption.InterviewRedemptionDataSet1();
            this.shipmentTableAdapter = new InterviewRedemption.InterviewRedemptionDataSet1TableAdapters.ShipmentTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addShipmentbutton1 = new System.Windows.Forms.Button();
            this.selectShipmentbutton2 = new System.Windows.Forms.Button();
            this.addContainerbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewRedemptionDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewRedemptionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewRedemptionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment AND Container Connection";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "INSEQUENCE   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Insert Shipment: #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Container : #";
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataMember = "Container";
            this.containerBindingSource.DataSource = this.interviewRedemptionDataSet;
            // 
            // interviewRedemptionDataSet
            // 
            this.interviewRedemptionDataSet.DataSetName = "InterviewRedemptionDataSet";
            this.interviewRedemptionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // containerTableAdapter
            // 
            this.containerTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 12;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // containerList
            // 
            this.containerList.AutoGenerateColumns = false;
            this.containerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.containerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shipmentIdDataGridViewTextBoxColumn});
            this.containerList.DataSource = this.containerBindingSource;
            this.containerList.Location = new System.Drawing.Point(410, 255);
            this.containerList.Name = "containerList";
            this.containerList.Size = new System.Drawing.Size(343, 183);
            this.containerList.TabIndex = 13;
            this.containerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // shipmentIdDataGridViewTextBoxColumn
            // 
            this.shipmentIdDataGridViewTextBoxColumn.DataPropertyName = "ShipmentId";
            this.shipmentIdDataGridViewTextBoxColumn.HeaderText = "ShipmentId";
            this.shipmentIdDataGridViewTextBoxColumn.Name = "shipmentIdDataGridViewTextBoxColumn";
            // 
            // interviewRedemptionDataSetBindingSource
            // 
            this.interviewRedemptionDataSetBindingSource.DataSource = this.interviewRedemptionDataSet;
            this.interviewRedemptionDataSetBindingSource.Position = 0;
            // 
            // shipmentList
            // 
            this.shipmentList.AutoGenerateColumns = false;
            this.shipmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.propertyIdDataGridViewTextBoxColumn});
            this.shipmentList.DataSource = this.shipmentBindingSource;
            this.shipmentList.Location = new System.Drawing.Point(32, 255);
            this.shipmentList.Name = "shipmentList";
            this.shipmentList.Size = new System.Drawing.Size(343, 183);
            this.shipmentList.TabIndex = 14;
            this.shipmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipmentList_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // propertyIdDataGridViewTextBoxColumn
            // 
            this.propertyIdDataGridViewTextBoxColumn.DataPropertyName = "PropertyId";
            this.propertyIdDataGridViewTextBoxColumn.HeaderText = "PropertyId";
            this.propertyIdDataGridViewTextBoxColumn.Name = "propertyIdDataGridViewTextBoxColumn";
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.interviewRedemptionDataSet1;
            // 
            // interviewRedemptionDataSet1
            // 
            this.interviewRedemptionDataSet1.DataSetName = "InterviewRedemptionDataSet1";
            this.interviewRedemptionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(481, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 16;
            // 
            // addShipmentbutton1
            // 
            this.addShipmentbutton1.Location = new System.Drawing.Point(232, 211);
            this.addShipmentbutton1.Name = "addShipmentbutton1";
            this.addShipmentbutton1.Size = new System.Drawing.Size(143, 23);
            this.addShipmentbutton1.TabIndex = 17;
            this.addShipmentbutton1.Text = "ADD SHIPMENT";
            this.addShipmentbutton1.UseVisualStyleBackColor = true;
            // 
            // selectShipmentbutton2
            // 
            this.selectShipmentbutton2.Location = new System.Drawing.Point(32, 211);
            this.selectShipmentbutton2.Name = "selectShipmentbutton2";
            this.selectShipmentbutton2.Size = new System.Drawing.Size(143, 23);
            this.selectShipmentbutton2.TabIndex = 18;
            this.selectShipmentbutton2.Text = "SELECT SHIPMENT";
            this.selectShipmentbutton2.UseVisualStyleBackColor = true;
            // 
            // addContainerbutton1
            // 
            this.addContainerbutton1.Location = new System.Drawing.Point(623, 211);
            this.addContainerbutton1.Name = "addContainerbutton1";
            this.addContainerbutton1.Size = new System.Drawing.Size(130, 23);
            this.addContainerbutton1.TabIndex = 19;
            this.addContainerbutton1.Text = "ADD CONTAINER";
            this.addContainerbutton1.UseVisualStyleBackColor = true;
            this.addContainerbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContainerListings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addContainerbutton1);
            this.Controls.Add(this.selectShipmentbutton2);
            this.Controls.Add(this.addShipmentbutton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shipmentList);
            this.Controls.Add(this.containerList);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContainerListings";
            this.Text = "Shipment Manager Console";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewRedemptionDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewRedemptionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewRedemptionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private InterviewRedemptionDataSet interviewRedemptionDataSet;
        private System.Windows.Forms.BindingSource containerBindingSource;
        private InterviewRedemptionDataSetTableAdapters.ContainerTableAdapter containerTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView containerList;
        private System.Windows.Forms.BindingSource interviewRedemptionDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView shipmentList;
        private InterviewRedemptionDataSet1 interviewRedemptionDataSet1;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private InterviewRedemptionDataSet1TableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addShipmentbutton1;
        private System.Windows.Forms.Button selectShipmentbutton2;
        private System.Windows.Forms.Button addContainerbutton1;
    }
}