namespace HospitalManagementSystem.Forms
{
    partial class InventoryManagmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbStockType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStockCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txbStockName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInventoryData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockCount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cmbStockType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudStockCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbStockName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(105, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.Location = new System.Drawing.Point(11, 199);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbStockType
            // 
            this.cmbStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbStockType.FormattingEnabled = true;
            this.cmbStockType.Items.AddRange(new object[] {
            "equipment",
            "medication"});
            this.cmbStockType.Location = new System.Drawing.Point(11, 152);
            this.cmbStockType.Name = "cmbStockType";
            this.cmbStockType.Size = new System.Drawing.Size(315, 28);
            this.cmbStockType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stock Type";
            // 
            // nudStockCount
            // 
            this.nudStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudStockCount.Location = new System.Drawing.Point(12, 99);
            this.nudStockCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStockCount.Name = "nudStockCount";
            this.nudStockCount.Size = new System.Drawing.Size(120, 26);
            this.nudStockCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Name";
            // 
            // txbStockName
            // 
            this.txbStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbStockName.Location = new System.Drawing.Point(12, 46);
            this.txbStockName.Name = "txbStockName";
            this.txbStockName.Size = new System.Drawing.Size(314, 26);
            this.txbStockName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvInventoryData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(369, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 450);
            this.panel2.TabIndex = 0;
            // 
            // dgvInventoryData
            // 
            this.dgvInventoryData.AllowUserToAddRows = false;
            this.dgvInventoryData.AllowUserToDeleteRows = false;
            this.dgvInventoryData.AllowUserToResizeRows = false;
            this.dgvInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryData.EnableHeadersVisualStyles = false;
            this.dgvInventoryData.Location = new System.Drawing.Point(0, 0);
            this.dgvInventoryData.Name = "dgvInventoryData";
            this.dgvInventoryData.ReadOnly = true;
            this.dgvInventoryData.RowHeadersVisible = false;
            this.dgvInventoryData.Size = new System.Drawing.Size(431, 450);
            this.dgvInventoryData.TabIndex = 1;
            this.dgvInventoryData.TabStop = false;
            this.dgvInventoryData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryData_CellContentDoubleClick);
            // 
            // InventoryManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryManagmentForm";
            this.Text = "InventoryManagmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockCount)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInventoryData;
        private System.Windows.Forms.TextBox txbStockName;
        private System.Windows.Forms.NumericUpDown nudStockCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStockType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
    }
}