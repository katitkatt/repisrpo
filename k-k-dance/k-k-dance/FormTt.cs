using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace k_k_dance
{
    public partial class FormTt : Form
    {
        private string _userRole;
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=курсовая;Integrated Security=True";
        public FormTt(string userRole)
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
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
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
                    string query = "SELECT * FROM timetable";
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
        private void FormTt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяDataSet.timetable". При необходимости она может быть перемещена или удалена.
            this.timetableTableAdapter.Fill(this.курсоваяDataSet.timetable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = @"INSERT INTO timetable (dance_styles_id, trainer_id, class_id, start_time, end_time, room_number) 
                               VALUES (@dance_styles_id,@trainer_id, @class_id, @start_time, @end_time, @room_number)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dance_styles_id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@trainer_id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@class_id", textBox3.Text);
                    cmd.Parameters.AddWithValue("@start_time", textBox4.Text);
                    cmd.Parameters.AddWithValue("@end_time", textBox5.Text);
                    cmd.Parameters.AddWithValue("@room_number", textBox6.Text);

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
            if (ValidateInputs())
            {
                string query = @"UPDATE timetable 
                               SET start_time = @start_time,
                                   end_time = @end_time,
                                   room_number = @room_number
                               WHERE trainer_id = @trainer_id 
                                 AND class_id = @class_id 
                                 AND dance_style_id = @dance_style_id";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dance_style_id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@trainer_id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@class_id", textBox3.Text);
                    cmd.Parameters.AddWithValue("@start_time", textBox4.Text);
                    cmd.Parameters.AddWithValue("@end_time", textBox5.Text);
                    cmd.Parameters.AddWithValue("@room_number", textBox6.Text);
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
            if (int.TryParse(textBox7.Text, out int id)&& int.TryParse(textBox8.Text, out int id1)&& int.TryParse(textBox9.Text, out int id2))
            {
                string query = "DELETE FROM timetable WHERE dance_styles_id =@id AND trainer_id = @id1 AND class_id = @id2";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@id1", id1);
                    cmd.Parameters.AddWithValue("@id2", id2);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadData();
                            textBox7.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
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
                textBox1.Text = row.Cells["dance_style_id"].Value.ToString();
                textBox2.Text = row.Cells["trainer_id"].Value.ToString();
                textBox3.Text = row.Cells["class_id"].Value.ToString();
                textBox4.Text = row.Cells["start_time"].Value.ToString();
                textBox5.Text = row.Cells["end_time"].Value.ToString();
                textBox6.Text = row.Cells["room_number"].Value.ToString();
            }
        }
    }
}
