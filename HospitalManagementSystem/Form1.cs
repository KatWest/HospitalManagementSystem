using HospitalManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        bool sidebarExpand = false;
        private Form activeForm;
        private User _currUser;
        public Form1()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            } 
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        public void LoginSetup(User u)
        {
            if (u != null)
            {
                _currUser = u;
                if (u.Role.ToLower() == "client")
                {
                    pnlDashboard.Visible = true;
                    pnlPatientManagement.Visible = false;
                    pnlAppointment.Visible = true;
                    pnlInventory.Visible = false;
                    pnlData.Visible = false;
                    pnlCommunication.Visible = true;
                    lblUser.Text = $"{u.FirstName} {u.LastName}";
                } 
                else
                {
                    pnlDashboard.Visible = true;
                    pnlPatientManagement.Visible = true;
                    pnlAppointment.Visible = true;
                    pnlInventory.Visible = true;
                    pnlData.Visible = true;
                    pnlCommunication.Visible = true;
                    lblUser.Text = $"{u.Role.Replace(u.Role.Substring(0,1), u.Role.Substring(0,1).ToUpper())} {u.FirstName} {u.LastName}";
                }
                btnDashboard_Click();
            }
            else
            {
                MessageBox.Show("Error", "Invalid User");
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktopPane.Controls.Add(childForm);
            pnlDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.GetType() == typeof(DashboardForm))
            {
                DashboardForm currForm = (DashboardForm)childForm;

                currForm.setupFormForUser(_currUser);
            }
            else if (childForm.GetType() == typeof(PatientManagementForm))
            {
                PatientManagementForm currForm = (PatientManagementForm)childForm;

                currForm.setupForm();
            }
            else if (childForm.GetType() == typeof(InventoryManagmentForm))
            {
                InventoryManagmentForm currForm = (InventoryManagmentForm)childForm;

                currForm.setupForm();
            }
        }

        private void sidebar_MouseClick(object sender, MouseEventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        { OpenChildForm(new Forms.DashboardForm()); }
        private void btnDashboard_Click() 
        { OpenChildForm(new Forms.DashboardForm()); }

        public void btnPatientManagement_Click(object sender, EventArgs e)
        { OpenChildForm(new Forms.PatientManagementForm()); }

        public void btnAppointment_Click(object sender, EventArgs e)
        { OpenChildForm(new Forms.AppointmentManagementForm()); }

        public void btnInventory_Click(object sender, EventArgs e)
        { OpenChildForm(new Forms.InventoryManagmentForm()); }

        public void btnData_Click(object sender, EventArgs e)
        { OpenChildForm(new Forms.DataAnlyticsForm()); }

        public void btnCommunication_Click(object sender, EventArgs e)
        { OpenChildForm(new Forms.CommunicationForm()); }
    }
}
