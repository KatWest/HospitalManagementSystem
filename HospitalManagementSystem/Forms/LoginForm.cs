using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MongoDB.Driver;

namespace HospitalManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        IMongoCollection<User> userCollection;
        public LoginForm()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);

            var database = mongoClient.GetDatabase(databaseName);

            userCollection = database.GetCollection<User>("users");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todo");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            var filter = Builders<User>.Filter.Eq("username", username) &
                Builders<User>.Filter.Eq("password", password);

            var user = userCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.LoginSetup(user);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
