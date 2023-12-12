using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacy_Inventory_System
{
    public partial class Pharmacy : Form
    {
        private const string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=pharmacy";

        public Pharmacy()
        {
            InitializeComponent();
            LoadStocksData();
        }

        private void LoadStocksData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT drug_code, drug_name, price, quantity FROM stocks";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewInventory.DataSource = dataTable;

                        // Hide the drug_code column, if it's not needed in the UI
                        dataGridViewInventory.Columns["drug_code"].Visible = false;

                        foreach (DataGridViewRow row in dataGridViewInventory.Rows)
                        {
                            int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                            if (quantity <= 5)
                            {
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                            }
                        }

                        if (HasLowQuantityItems(dataTable))
                        {
                            MessageBox.Show("Warning: Some items have a quantity of 5 or below.", "Low Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error loading stocks data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasLowQuantityItems(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int quantity = Convert.ToInt32(row["quantity"]);
                if (quantity <= 5)
                {
                    return true;
                }
            }
            return false;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("INSERT INTO stocks (drug_name, quantity, price) VALUES (@DrugName, @Quantity, @Price);", connection))
                    {
                        command.Parameters.AddWithValue("@DrugName", txtDrugName.Text);
                        command.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStocksData();
                        ClearTextBoxes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewInventory.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewInventory.SelectedCells[0].RowIndex;
                    int drugCode = Convert.ToInt32(dataGridViewInventory.Rows[selectedRowIndex].Cells["drug_code"].Value);

                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand("UPDATE stocks SET drug_name = @DrugName, quantity = @Quantity, price = @Price WHERE drug_code = @DrugCode;", connection))
                        {
                            command.Parameters.AddWithValue("@DrugCode", drugCode);
                            command.Parameters.AddWithValue("@DrugName", txtDrugName.Text);
                            command.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                            command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                            command.ExecuteNonQuery();

                            MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStocksData();
                            ClearTextBoxes();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewInventory.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewInventory.SelectedCells[0].RowIndex;
                    int drugCode = Convert.ToInt32(dataGridViewInventory.Rows[selectedRowIndex].Cells["drug_code"].Value);

                    DialogResult result = MessageBox.Show("Do you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                        {
                            connection.Open();

                            using (MySqlCommand command = new MySqlCommand("DELETE FROM stocks WHERE drug_code = @DrugCode;", connection))
                            {
                                command.Parameters.AddWithValue("@DrugCode", drugCode);

                                command.ExecuteNonQuery();

                                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadStocksData();
                                ClearTextBoxes();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            LoadStocksData();
        }

        private void ClearTextBoxes()
        {
            txtDrugName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
