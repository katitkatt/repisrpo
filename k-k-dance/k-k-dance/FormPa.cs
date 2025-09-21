using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace k_k_dance
{
    public partial class FormPa : Form
    {
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=курсовая;Integrated Security=True";
        public FormPa(string userRole)
        {
            if (userRole == "пользователь")
            {
                MessageBox.Show("Доступ запрещен!");
                this.Close();
                return;
            }
            FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            LoadData();
            ConfigureGrid();
        }
        private void ConfigureGrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM payments";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void FormPa_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяDataSet.payments". При необходимости она может быть перемещена или удалена.
            this.paymentsTableAdapter.Fill(this.курсоваяDataSet.payments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = @"INSERT INTO payments (payment_id, stud_id, payment_date, method, abon_id, amount) 
                               VALUES (@payment_id, @stud_id, @payment_date, @method, @abon_id, @amount)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@payment_id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@stud_id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@payment_date", textBox3.Text);
                    cmd.Parameters.AddWithValue("@method", textBox4.Text);
                    cmd.Parameters.AddWithValue("@abon_id", textBox5.Text);
                    cmd.Parameters.AddWithValue("@amount", textBox6.Text);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        LoadData(); // Обновляем данные
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка добавления: {ex.Message}");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && int.TryParse(textBox1.Text, out int id))
            {
                string query = @"UPDATE payments 
                               SET stud_id = @stud_id, 
                                   payment_date = @payment_date, 
                                   method = @method,
                                   abon_id = @abon_id,
                                   amount = @amount
                               WHERE payment_id = @id";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@stud_id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@payment_date", textBox3.Text);
                    cmd.Parameters.AddWithValue("@method", textBox4.Text);
                    cmd.Parameters.AddWithValue("@abon_id", textBox5.Text);
                    cmd.Parameters.AddWithValue("@amount", textBox6.Text);
                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadData();
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Запись не найдена!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка обновления: {ex.Message}");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox7.Text, out int id))
            {
                string query = "DELETE FROM payments WHERE payment_id = @id";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadData();
                            textBox5.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Запись не найдена!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка удаления: {ex.Message}");
                    }
                }
            }
        }
        //проверка заполнености полей
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
            return true;
        }
        //очистка полей
        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["payment_id"].Value.ToString();
                textBox2.Text = row.Cells["stud_id"].Value.ToString();
                textBox3.Text = row.Cells["payment_date"].Value.ToString();
                textBox4.Text = row.Cells["method"].Value.ToString();
                textBox5.Text = row.Cells["abon_id"].Value.ToString();
                textBox6.Text = row.Cells["amount"].Value.ToString();
            }
        }
    }
}
