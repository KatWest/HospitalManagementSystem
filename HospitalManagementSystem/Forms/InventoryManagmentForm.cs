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
    public partial class InventoryManagmentForm : Form
    {
        SQLDatabaseService sqlDatabaseService = new SQLDatabaseService();
        AutoCompleteStringCollection stockData = new AutoCompleteStringCollection();

        public InventoryManagmentForm()
        {
            InitializeComponent();
        }
        public void setupForm()
        {
            dgvInventoryData.DataSource = sqlDatabaseService.GetStock();

            List<StockItem> stock = sqlDatabaseService.GetStock();

            foreach (StockItem med in stock)
                stockData.Add(med.ItemName);

            //txbMedicationSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txbMedicationSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            //txbMedicationSearch.AutoCompleteCustomSource = medicationStockData;
        }
    }
}
