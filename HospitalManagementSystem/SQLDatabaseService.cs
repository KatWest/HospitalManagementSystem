using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HospitalManagementSystem
{
    public class SQLDatabaseService
    {
        //string patientDbConnectionString = ConfigurationManager.ConnectionStrings["PatientDatabaseConnection"].ConnectionString;
        string patientDbConnectionString = "Data Source=SleepingBeauty\\SQLEXPRESS;Initial Catalog=PatientDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection sqlConnection = new SqlConnection(patientDbConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("Select * FROM patient", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string patientMeds = "";
                    if (!reader.IsDBNull(4))
                        patientMeds = reader.GetString(4);

                    patients.Add(new Patient()
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Address = reader.GetString(3),
                        CurrentMedications = patientMeds,
                        Birthdate = reader.GetDateTime(5)
                    });
                }
            }
            return patients;
        }
        public void AddPatient(Patient patient)
        {
            using (SqlConnection sqlConnection = new SqlConnection(patientDbConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO patient(FirstName,LastName,Address,CurrentMedications,Birthdate) VALUES(" +
                    "@FirstName," +
                    "@LastName," +
                    "@Address," +
                    "@CurrentMedications," +
                    "@Birthdate)");
                command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                command.Parameters.AddWithValue("@LastName", patient.LastName);
                command.Parameters.AddWithValue("@Address", patient.Address);
                command.Parameters.AddWithValue("@CurrentMedications", patient.CurrentMedications);
                command.Parameters.AddWithValue("@Birthdate", patient.Birthdate);

                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void UpdatePatient(Patient patient)
        {
            using (SqlConnection sqlConnection = new SqlConnection(patientDbConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("UPDATE patient SET " +
                    "FirstName=@FirstName," +
                    "LastName=@LastName," +
                    "Address=@Address," +
                    "CurrentMedications=@CurrentMedications," +
                    "Birthdate=@Birthdate " +
                    "WHERE Id=@ID");
                command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                command.Parameters.AddWithValue("@LastName", patient.LastName);
                command.Parameters.AddWithValue("@Address", patient.Address);
                command.Parameters.AddWithValue("@CurrentMedications", patient.CurrentMedications);
                command.Parameters.AddWithValue("@Birthdate", patient.Birthdate);
                command.Parameters.AddWithValue("@ID", patient.Id);

                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public List<StockItem> GetStock()
        {
            List<StockItem> stockItems = new List<StockItem>();

            using (SqlConnection sqlConnection = new SqlConnection(patientDbConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("Select * FROM stock", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    stockItems.Add(new StockItem()
                    {
                        Id = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        StockCount = reader.GetInt32(2),
                        ItemType = reader.GetString(3)
                    });
                }
            }

            return stockItems;
        }

        public List<StockItem> GetMedicationStock()
        {
            List<StockItem> medicationStock = new List<StockItem>();

            using (SqlConnection sqlConnection = new SqlConnection(patientDbConnectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("Select * FROM stock WHERE ItemType='medication'", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    medicationStock.Add(new StockItem()
                    {
                        Id = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        StockCount = reader.GetInt32(2),
                        ItemType = reader.GetString(3)
                    });
                }
            }

            return medicationStock;
        }
    }


    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CurrentMedications { get; set; }
        public DateTime Birthdate { get; set; }
    }
    public class CurrentMedications
    {
        public List<Medication> Medications { get; set; }
    }
    public class Medication
    {
        public string MedicationName { get; set; }
        public double MedicationDose { get; set; }
        public string Frequency { get; set; }
    }
    public class StockItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int StockCount { get; set; }
        public string ItemType { get; set; }
    }
}
