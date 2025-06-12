namespace HospitalManagementSystem.Forms
{
    partial class PatientManagementForm
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
            this.dgvPatientData = new System.Windows.Forms.DataGridView();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPatientMedications = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveMedications = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txbMedicationSearch = new System.Windows.Forms.TextBox();
            this.txbMedDose = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMedFreq = new System.Windows.Forms.TextBox();
            this.btnAddMedication = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedications)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatientData
            // 
            this.dgvPatientData.AllowUserToAddRows = false;
            this.dgvPatientData.AllowUserToDeleteRows = false;
            this.dgvPatientData.AllowUserToResizeRows = false;
            this.dgvPatientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPatientData.EnableHeadersVisualStyles = false;
            this.dgvPatientData.Location = new System.Drawing.Point(0, 71);
            this.dgvPatientData.Name = "dgvPatientData";
            this.dgvPatientData.ReadOnly = true;
            this.dgvPatientData.RowHeadersVisible = false;
            this.dgvPatientData.Size = new System.Drawing.Size(386, 379);
            this.dgvPatientData.TabIndex = 0;
            this.dgvPatientData.TabStop = false;
            this.dgvPatientData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientData_CellDoubleClick);
            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.Location = new System.Drawing.Point(25, 43);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(119, 26);
            this.txbFirstName.TabIndex = 1;
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLastName.Location = new System.Drawing.Point(143, 43);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(139, 26);
            this.txbLastName.TabIndex = 2;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(25, 147);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(124, 26);
            this.dtpBirthdate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Medications";
            // 
            // dgvPatientMedications
            // 
            this.dgvPatientMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientMedications.EnableHeadersVisualStyles = false;
            this.dgvPatientMedications.Location = new System.Drawing.Point(25, 285);
            this.dgvPatientMedications.Name = "dgvPatientMedications";
            this.dgvPatientMedications.RowHeadersVisible = false;
            this.dgvPatientMedications.Size = new System.Drawing.Size(354, 62);
            this.dgvPatientMedications.TabIndex = 0;
            this.dgvPatientMedications.TabStop = false;
            this.dgvPatientMedications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientMedications_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search";
            // 
            // btnRemoveMedications
            // 
            this.btnRemoveMedications.Location = new System.Drawing.Point(304, 353);
            this.btnRemoveMedications.Name = "btnRemoveMedications";
            this.btnRemoveMedications.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMedications.TabIndex = 8;
            this.btnRemoveMedications.Text = "Remove";
            this.btnRemoveMedications.UseVisualStyleBackColor = true;
            this.btnRemoveMedications.Click += new System.EventHandler(this.btnRemoveMedications_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdatePatient.Location = new System.Drawing.Point(25, 381);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(84, 31);
            this.btnUpdatePatient.TabIndex = 10;
            this.btnUpdatePatient.Text = "Update";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddPatient.Location = new System.Drawing.Point(115, 381);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(84, 31);
            this.btnAddPatient.TabIndex = 11;
            this.btnAddPatient.Text = "Add";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // txbMedicationSearch
            // 
            this.txbMedicationSearch.Location = new System.Drawing.Point(81, 208);
            this.txbMedicationSearch.Name = "txbMedicationSearch";
            this.txbMedicationSearch.Size = new System.Drawing.Size(213, 20);
            this.txbMedicationSearch.TabIndex = 5;
            // 
            // txbMedDose
            // 
            this.txbMedDose.Location = new System.Drawing.Point(81, 235);
            this.txbMedDose.Name = "txbMedDose";
            this.txbMedDose.Size = new System.Drawing.Size(213, 20);
            this.txbMedDose.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dose";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Frequency";
            // 
            // txbMedFreq
            // 
            this.txbMedFreq.Location = new System.Drawing.Point(81, 259);
            this.txbMedFreq.Name = "txbMedFreq";
            this.txbMedFreq.Size = new System.Drawing.Size(213, 20);
            this.txbMedFreq.TabIndex = 7;
            // 
            // btnAddMedication
            // 
            this.btnAddMedication.Location = new System.Drawing.Point(304, 257);
            this.btnAddMedication.Name = "btnAddMedication";
            this.btnAddMedication.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedication.TabIndex = 8;
            this.btnAddMedication.Text = "Add";
            this.btnAddMedication.UseVisualStyleBackColor = true;
            this.btnAddMedication.Click += new System.EventHandler(this.btnAddMedication_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMedFreq);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbMedDose);
            this.panel1.Controls.Add(this.txbAddress);
            this.panel1.Controls.Add(this.txbFirstName);
            this.panel1.Controls.Add(this.txbMedicationSearch);
            this.panel1.Controls.Add(this.txbLastName);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Controls.Add(this.dtpBirthdate);
            this.panel1.Controls.Add(this.btnUpdatePatient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddMedication);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRemoveMedications);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvPatientMedications);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 450);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(21, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Patient Address";
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(25, 94);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(257, 26);
            this.txbAddress.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPatientData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(414, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 450);
            this.panel2.TabIndex = 12;
            // 
            // PatientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientManagementForm";
            this.Text = "PatientManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedications)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientData;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPatientMedications;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveMedications;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.TextBox txbMedicationSearch;
        private System.Windows.Forms.TextBox txbMedDose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMedFreq;
        private System.Windows.Forms.Button btnAddMedication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAddress;
    }
}