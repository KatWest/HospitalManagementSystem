namespace HospitalManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHambuger = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlPatientManagement = new System.Windows.Forms.Panel();
            this.pnlAppointment = new System.Windows.Forms.Panel();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlCommunication = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlDesktopPane = new System.Windows.Forms.Panel();
            this.btnHamburger = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPatientManagement = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnCommunication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogo.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnlHambuger.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlPatientManagement.SuspendLayout();
            this.pnlAppointment.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlCommunication.SuspendLayout();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(100, 69);
            this.pnlLogo.TabIndex = 0;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sidebar.Controls.Add(this.pnlHambuger);
            this.sidebar.Controls.Add(this.pnlDashboard);
            this.sidebar.Controls.Add(this.pnlPatientManagement);
            this.sidebar.Controls.Add(this.pnlAppointment);
            this.sidebar.Controls.Add(this.pnlInventory);
            this.sidebar.Controls.Add(this.pnlData);
            this.sidebar.Controls.Add(this.pnlCommunication);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 69);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 2000);
            this.sidebar.MinimumSize = new System.Drawing.Size(50, 492);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(50, 492);
            this.sidebar.TabIndex = 2;
            // 
            // pnlHambuger
            // 
            this.pnlHambuger.Controls.Add(this.btnHamburger);
            this.pnlHambuger.Location = new System.Drawing.Point(3, 3);
            this.pnlHambuger.Name = "pnlHambuger";
            this.pnlHambuger.Size = new System.Drawing.Size(197, 50);
            this.pnlHambuger.TabIndex = 3;
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
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.btnDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(3, 59);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(197, 50);
            this.pnlDashboard.TabIndex = 3;
            // 
            // pnlPatientManagement
            // 
            this.pnlPatientManagement.Controls.Add(this.btnPatientManagement);
            this.pnlPatientManagement.Location = new System.Drawing.Point(3, 115);
            this.pnlPatientManagement.Name = "pnlPatientManagement";
            this.pnlPatientManagement.Size = new System.Drawing.Size(197, 50);
            this.pnlPatientManagement.TabIndex = 3;
            // 
            // pnlAppointment
            // 
            this.pnlAppointment.Controls.Add(this.btnAppointment);
            this.pnlAppointment.Location = new System.Drawing.Point(3, 171);
            this.pnlAppointment.Name = "pnlAppointment";
            this.pnlAppointment.Size = new System.Drawing.Size(197, 50);
            this.pnlAppointment.TabIndex = 3;
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.btnInventory);
            this.pnlInventory.Location = new System.Drawing.Point(3, 227);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(197, 50);
            this.pnlInventory.TabIndex = 3;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnData);
            this.pnlData.Location = new System.Drawing.Point(3, 283);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(197, 50);
            this.pnlData.TabIndex = 3;
            // 
            // pnlCommunication
            // 
            this.pnlCommunication.Controls.Add(this.btnCommunication);
            this.pnlCommunication.Location = new System.Drawing.Point(3, 339);
            this.pnlCommunication.Name = "pnlCommunication";
            this.pnlCommunication.Size = new System.Drawing.Size(197, 50);
            this.pnlCommunication.TabIndex = 3;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlHead.Controls.Add(this.lblUser);
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Controls.Add(this.pnlLogo);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(984, 69);
            this.pnlHead.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(780, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Welcome!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(780, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlDesktopPane
            // 
            this.pnlDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktopPane.Location = new System.Drawing.Point(50, 69);
            this.pnlDesktopPane.Name = "pnlDesktopPane";
            this.pnlDesktopPane.Size = new System.Drawing.Size(934, 492);
            this.pnlDesktopPane.TabIndex = 6;
            // 
            // btnHamburger
            // 
            this.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHamburger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHamburger.ImageIndex = 0;
            this.btnHamburger.ImageList = this.imageList1;
            this.btnHamburger.Location = new System.Drawing.Point(-10, -5);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(230, 60);
            this.btnHamburger.TabIndex = 4;
            this.btnHamburger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHamburger.UseVisualStyleBackColor = true;
            this.btnHamburger.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sidebar_MouseClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.ImageIndex = 1;
            this.btnDashboard.ImageList = this.imageList1;
            this.btnDashboard.Location = new System.Drawing.Point(-10, -5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(230, 60);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPatientManagement
            // 
            this.btnPatientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientManagement.ImageIndex = 2;
            this.btnPatientManagement.ImageList = this.imageList1;
            this.btnPatientManagement.Location = new System.Drawing.Point(-10, -5);
            this.btnPatientManagement.Name = "btnPatientManagement";
            this.btnPatientManagement.Size = new System.Drawing.Size(217, 60);
            this.btnPatientManagement.TabIndex = 4;
            this.btnPatientManagement.Text = "          Patient  \r\n          Management";
            this.btnPatientManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientManagement.UseVisualStyleBackColor = true;
            this.btnPatientManagement.Click += new System.EventHandler(this.btnPatientManagement_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.ImageIndex = 3;
            this.btnAppointment.ImageList = this.imageList1;
            this.btnAppointment.Location = new System.Drawing.Point(-10, -5);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(217, 60);
            this.btnAppointment.TabIndex = 4;
            this.btnAppointment.Text = "          Appointment\r\n          Scheduling";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.ImageIndex = 2;
            this.btnInventory.ImageList = this.imageList1;
            this.btnInventory.Location = new System.Drawing.Point(-10, -5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(217, 60);
            this.btnInventory.TabIndex = 4;
            this.btnInventory.Text = "          Inventory\r\n          Management";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnData
            // 
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.ImageIndex = 2;
            this.btnData.ImageList = this.imageList1;
            this.btnData.Location = new System.Drawing.Point(-10, -5);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(217, 60);
            this.btnData.TabIndex = 4;
            this.btnData.Text = "          Data\r\n          Analytics";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnCommunication
            // 
            this.btnCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommunication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommunication.ImageIndex = 4;
            this.btnCommunication.ImageList = this.imageList1;
            this.btnCommunication.Location = new System.Drawing.Point(-10, -5);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(217, 60);
            this.btnCommunication.TabIndex = 4;
            this.btnCommunication.Text = "          Communication";
            this.btnCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommunication.UseVisualStyleBackColor = true;
            this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.health_3;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlDesktopPane);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnlHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Hospital Management System";
            this.pnlLogo.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.pnlHambuger.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlPatientManagement.ResumeLayout(false);
            this.pnlAppointment.ResumeLayout(false);
            this.pnlInventory.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlCommunication.ResumeLayout(false);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pnlPatientManagement;
        private System.Windows.Forms.Button btnPatientManagement;
        private System.Windows.Forms.Panel pnlAppointment;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Panel pnlCommunication;
        private System.Windows.Forms.Button btnCommunication;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlHambuger;
        private System.Windows.Forms.Button btnHamburger;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDesktopPane;
    }
}

