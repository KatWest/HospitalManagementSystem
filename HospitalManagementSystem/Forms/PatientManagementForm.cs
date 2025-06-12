using MongoDB.Bson.IO;
using Newtonsoft.Json;
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
    public partial class PatientManagementForm : Form
    {
        SQLDatabaseService sqlDatabaseService = new SQLDatabaseService();
        AutoCompleteStringCollection medicationStockData = new AutoCompleteStringCollection();
        List<Medication> currentMeds = new List<Medication>();

        public PatientManagementForm()
        {
            InitializeComponent();
        }

        public void setupForm()
        {
            dgvPatientData.DataSource = sqlDatabaseService.GetPatients();
            dgvPatientData.Columns["Address"].Visible = false;
            dgvPatientData.Columns["CurrentMedications"].Visible = false;
            dgvPatientData.Columns["Birthdate"].Visible = false;

            List<StockItem> medicationStock = sqlDatabaseService.GetMedicationStock();

            foreach (StockItem med in medicationStock)
                medicationStockData.Add(med.ItemName);

            txbMedicationSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txbMedicationSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            txbMedicationSearch.AutoCompleteCustomSource = medicationStockData;
        }

        private int patientId = -1;
        private void dgvPatientData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string patientMeds = dgvPatientData.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (patientMeds != "")
            {
                currentMeds = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Medication>>(patientMeds);
            }

            if (e.RowIndex == -1) return;
            patientId = Convert.ToInt32(dgvPatientData.Rows[e.RowIndex].Cells[0].Value);
            txbFirstName.Text = dgvPatientData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbLastName.Text = dgvPatientData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbAddress.Text = dgvPatientData.Rows[e.RowIndex].Cells[3].Value.ToString();
            dgvPatientMedications.DataSource = currentMeds;
            dtpBirthdate.Value = (DateTime)dgvPatientData.Rows[e.RowIndex].Cells[5].Value;
        }

        private int selectedMedIndex = -1;
        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            dgvPatientMedications.DataSource = null;
            // remaking the list is required bc dgvs and empty lists don't play well together
            // https://forums.codeguru.com/showthread.php?513902-RESOLVED-Wierd-Problem-with-DGV 
            if (currentMeds.Count == 0) 
                currentMeds = new List<Medication>();

            Medication med = new Medication
            {
                MedicationName = txbMedicationSearch.Text,
                MedicationDose = Convert.ToDouble(txbMedDose.Text),
                Frequency = txbMedFreq.Text
            };
            currentMeds.Add(med);
            dgvPatientMedications.DataSource = currentMeds;
        }
        private void dgvPatientMedications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedMedIndex = e.RowIndex;
        }
        private void btnRemoveMedications_Click(object sender, EventArgs e)
        {
            if (selectedMedIndex != -1)
            {
                currentMeds.RemoveAt(selectedMedIndex);
                selectedMedIndex = -1;
                dgvPatientMedications.DataSource = null;
                dgvPatientMedications.DataSource = currentMeds;
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            string patientMeds = Newtonsoft.Json.JsonConvert.SerializeObject(currentMeds);            
            Patient patient = new Patient
            {
                Id = patientId,
                FirstName = txbFirstName.Text,
                LastName = txbLastName.Text,
                Address = txbAddress.Text,
                CurrentMedications = patientMeds,
                Birthdate = dtpBirthdate.Value
            };
            sqlDatabaseService.UpdatePatient(patient);

            dgvPatientData.DataSource = null;
            dgvPatientData.DataSource = sqlDatabaseService.GetPatients();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string patientMeds = Newtonsoft.Json.JsonConvert.SerializeObject(currentMeds);
            Patient patient = new Patient
            {
                Id = -1,
                FirstName = txbFirstName.Text,
                LastName = txbLastName.Text,
                Address = txbAddress.Text,
                CurrentMedications = patientMeds,
                Birthdate = dtpBirthdate.Value
            };
            sqlDatabaseService.AddPatient(patient);

            dgvPatientData.DataSource = null;
            dgvPatientData.DataSource = sqlDatabaseService.GetPatients();
        }
    }
}
