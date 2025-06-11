namespace HospitalManagementSystem.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.btnPatientManagement = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnCommunication = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatientManagement
            // 
            this.btnPatientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatientManagement.ImageIndex = 2;
            this.btnPatientManagement.ImageList = this.imageList1;
            this.btnPatientManagement.Location = new System.Drawing.Point(3, 3);
            this.btnPatientManagement.Name = "btnPatientManagement";
            this.btnPatientManagement.Size = new System.Drawing.Size(100, 100);
            this.btnPatientManagement.TabIndex = 0;
            this.btnPatientManagement.Text = "Patient Management";
            this.btnPatientManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientManagement.UseVisualStyleBackColor = true;
            this.btnPatientManagement.Click += new System.EventHandler(this.btnPatientManagement_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "menu-hamburger.png");
            this.imageList1.Images.SetKeyName(1, "house-112.png");
            this.imageList1.Images.SetKeyName(2, "notebook-52.png");
            this.imageList1.Images.SetKeyName(3, "calendar-412.png");
            this.imageList1.Images.SetKeyName(4, "bubble-comment-text-chatterbox-chat-message.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPatientManagement);
            this.flowLayoutPanel1.Controls.Add(this.btnAppointment);
            this.flowLayoutPanel1.Controls.Add(this.btnInventory);
            this.flowLayoutPanel1.Controls.Add(this.btnData);
            this.flowLayoutPanel1.Controls.Add(this.btnCommunication);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAppointment
            // 
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAppointment.ImageIndex = 3;
            this.btnAppointment.ImageList = this.imageList1;
            this.btnAppointment.Location = new System.Drawing.Point(109, 3);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(100, 100);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "Appointment Scheduling";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInventory.ImageIndex = 2;
            this.btnInventory.ImageList = this.imageList1;
            this.btnInventory.Location = new System.Drawing.Point(215, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(100, 100);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory Management";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnData
            // 
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnData.ImageIndex = 2;
            this.btnData.ImageList = this.imageList1;
            this.btnData.Location = new System.Drawing.Point(321, 3);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(100, 100);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "Data Analytics\r\n";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnCommunication
            // 
            this.btnCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommunication.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCommunication.ImageIndex = 4;
            this.btnCommunication.ImageList = this.imageList1;
            this.btnCommunication.Location = new System.Drawing.Point(427, 3);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(100, 100);
            this.btnCommunication.TabIndex = 0;
            this.btnCommunication.Text = "Communication";
            this.btnCommunication.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCommunication.UseVisualStyleBackColor = true;
            this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatientManagement;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnCommunication;
    }
}