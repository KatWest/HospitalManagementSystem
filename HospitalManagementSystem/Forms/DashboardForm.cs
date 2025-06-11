using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    public partial class DashboardForm : Form
    {
        Form1 mainForm;
        public DashboardForm()
        {
            InitializeComponent();
            mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        }

        public void setupFormForUser(User u)
        {
            if (u != null)
            {
                if (u.Role.ToLower() == "client")
                {
                    btnPatientManagement.Visible = false;
                    btnAppointment.Visible = true;
                    btnInventory.Visible = false;
                    btnData.Visible = false;
                    btnCommunication.Visible = true;
                }
                else
                {
                    btnPatientManagement.Visible = true;
                    btnAppointment.Visible = true;
                    btnInventory.Visible = true;
                    btnData.Visible = true;
                    btnCommunication.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Error", "Invalid User");
            }
        }

        private void btnPatientManagement_Click(object sender, EventArgs e)
        { mainForm.btnPatientManagement_Click(sender, e); }
        private void btnAppointment_Click(object sender, EventArgs e)
        { mainForm.btnAppointment_Click(sender, e); }
        private void btnInventory_Click(object sender, EventArgs e)
        { mainForm.btnInventory_Click(sender, e); }
        private void btnData_Click(object sender, EventArgs e)
        { mainForm.btnData_Click(sender, e); }
        private void btnCommunication_Click(object sender, EventArgs e)
        { mainForm.btnCommunication_Click(sender, e); }
    }
}
