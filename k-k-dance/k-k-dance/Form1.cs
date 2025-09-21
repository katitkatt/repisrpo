using System;
using System.Windows.Forms;

namespace k_k_dance
{
    public partial class FormAutorisation : Form
    {
        public FormAutorisation()
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            string role = comboBox1.SelectedItem.ToString();
            string password = textBox1.Text;
            if ((role == "админ" && password == "admin1"))
            {
                this.Hide();
                new Form2("админ").Show();                       
            }else if (role == "пользователь" && password == "user1")
            {
                this.Hide();
                new Form2("пользователь").Show();
               
            }else
            {
                MessageBox.Show("Неверные данные!", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
    }
}
