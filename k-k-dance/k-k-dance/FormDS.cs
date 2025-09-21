using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace k_k_dance
{
    public partial class FormDS : Form
    {
        private string _userRole;
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=курсовая;Integrated Security=True";
        public FormDS(string userRole)
        {
            _userRole = userRole;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            ConfigureAccess();
            LoadData();
            ConfigureGrid();
        }
        private void ConfigureAccess()
        {
            if (_userRole == "пользователь")
            {
                button1.Visible = false; // Добавить
                button2.Visible = false; // Обновить
                button3.Visible = false; // Удалить
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox5.Enabled = false;
            }
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
                    string query = "SELECT * FROM dance_styles";
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

        private void FormDS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяDataSet.dance_styles". При необходимости она может быть перемещена или удалена.
            this.dance_stylesTableAdapter.Fill(this.курсоваяDataSet.dance_styles);

        }
        //кнопка ADD
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = @"INSERT INTO dance_styles (dance_styles_id, style_name, trainer_id) 
                               VALUES (@dance_styles_id, @style_name, @trainer_id)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dance_styles_id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@style_name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@trainer_id", textBox3.Text);

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
        //кнопка UPDATE
        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && int.TryParse(textBox1.Text, out int id))
            {
                string query = @"UPDATE dance_styles 
                               SET style_name = @name, 
                                   trainer_id = @tr_id                                  
                               WHERE dance_styles_id = @id";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@tr_id", textBox3.Text);
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
        //кнопка DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int id))
            {
                string query = "DELETE FROM dance_styles WHERE dance_styles_id = @id";

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
                string.IsNullOrWhiteSpace(textBox3.Text))
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["dance_style_id"].Value.ToString();
                textBox2.Text = row.Cells["style_name"].Value.ToString();
                textBox3.Text = row.Cells["trainer_id"].Value.ToString();
            }
        }
    }
}
