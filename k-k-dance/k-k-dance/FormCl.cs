using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_k_dance
{
    public partial class FormCl : Form
    {
        private string _userRole;
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=курсовая;Integrated Security=True";
        public FormCl(string userRole)
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
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
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
                    string query = "SELECT * FROM classes";
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
        private void FormCl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяDataSet.classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.курсоваяDataSet.classes);

        }
        //кнопка ADD
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = @"INSERT INTO classes (class_id, trainer_id, [group], level, format) 
                               VALUES (@class_id, @trainer_id, @group, @level, @format)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@class_id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@trainer_id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@group", textBox3.Text);
                    cmd.Parameters.AddWithValue("@level", textBox4.Text);
                    cmd.Parameters.AddWithValue("@format", textBox5.Text);

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
                string query = @"UPDATE classes 
                               SET trainer_id = @trainer_id, 
                                   [group] = @group, 
                                   level = @level,
                                   format = @format
                               WHERE class_id = @id";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@trainer_id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@group", textBox3.Text);
                    cmd.Parameters.AddWithValue("@level", textBox4.Text);
                    cmd.Parameters.AddWithValue("@format", textBox5.Text);
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
            if (int.TryParse(textBox6.Text, out int id))
            {
                string query = "DELETE FROM classes WHERE class_id = @id";

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
                string.IsNullOrWhiteSpace(textBox5.Text))
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["class_id"].Value.ToString();
                textBox2.Text = row.Cells["trainer_id"].Value.ToString();
                textBox3.Text = row.Cells["group"].Value.ToString();
                textBox4.Text = row.Cells["level"].Value.ToString();
                textBox5.Text = row.Cells["format"].Value.ToString();
            }
        }

       
    }
}
