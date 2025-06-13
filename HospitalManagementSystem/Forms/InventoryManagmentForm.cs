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
            //dgvInventoryData.DataSource = sqlDatabaseService.GetStock();
            List<StockItem> stock = sqlDatabaseService.GetStock();

            foreach (StockItem item in stock)
                stockData.Add(item.ItemName);
            dgvInventoryData.DataSource = stock;
        }

        private int itemId = -1;
        private void dgvInventoryData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            itemId = Convert.ToInt32(dgvInventoryData.Rows[e.RowIndex].Cells[0].Value);
            txbStockName.Text = dgvInventoryData.Rows[e.RowIndex].Cells[1].Value.ToString();
            nudStockCount.Value = Convert.ToInt32(dgvInventoryData.Rows[e.RowIndex].Cells[2].Value);
            cmbStockType.Text = dgvInventoryData.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StockItem item = new StockItem
            {
                Id = itemId,
                ItemName = txbStockName.Text,
                StockCount = Convert.ToInt32(nudStockCount.Value),
                ItemType = cmbStockType.Text
            };
            sqlDatabaseService.UpdateStock(item);

            dgvInventoryData.DataSource = null;
            dgvInventoryData.DataSource = sqlDatabaseService.GetStock();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockItem item = new StockItem
            {
                Id = -1,
                ItemName = txbStockName.Text,
                StockCount = Convert.ToInt32(nudStockCount.Value),
                ItemType = cmbStockType.Text
            };
            sqlDatabaseService.AddStock(item);

            dgvInventoryData.DataSource = null;
        }
    }
}
