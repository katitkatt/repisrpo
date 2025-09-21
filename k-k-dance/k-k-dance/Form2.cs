using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace k_k_dance
{
    public partial class Form2 : Form
    {
        private string _userrole;
        private Dictionary<string, Type> _tableForms = new Dictionary<string, Type>();
        public Form2(string urole)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            _userrole = urole;
            this.IsMdiContainer = true;
            InitializeTableForms();
            SetupMenu();
            
        }
        private void InitializeTableForms()
        {
            _tableForms = new Dictionary<string, Type>
        {
            {"students", typeof(FormSt)},
            {"trainers", typeof(FormTr)},
            {"dance_styles", typeof(FormDS)},
            {"classes", typeof(FormCl)},
            {"timetable", typeof(FormTt)},
            {"attendance", typeof(FormAt)},
            {"payments", typeof(FormPa)},
            {"abonements", typeof(FormAb)}
           
        };
        }
        private void SetupMenu()
        {
            var availableTables = _tableForms.Keys.ToList();

            // Скрываем таблицу payments для пользователя
            if (_userrole == "пользователь")
            {
                availableTables.Remove("payments");
            }
            toolStripComboBox1.Items.AddRange(_tableForms.Keys.ToArray());
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            toolStripComboBox1.SelectedIndex = 0;
        }


        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tableName = toolStripComboBox1.SelectedItem.ToString();
            OpenTableForm(tableName);
        }
        private void OpenTableForm(string tableName)
        {
            if (!_tableForms.ContainsKey(tableName)) return;

            // Закрываем предыдущие формы того же типа
            foreach (var form in MdiChildren.OfType<Form>()
                         .Where(f => f.GetType() == _tableForms[tableName]))
            {
                form.Close();
            }

            try
            {
                var formType = _tableForms[tableName];
                Form form = (Form)Activator.CreateInstance(formType, _userrole);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы: {ex.Message}");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти к авторизации?",
                                               "Подтверждение выхода",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Закрываем все дочерние формы
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }

                // Показываем форму авторизации
                var authForm = new FormAutorisation();
                authForm.Show();

                // Закрываем текущую форму
                this.Close();
            }
        }
    }
}
