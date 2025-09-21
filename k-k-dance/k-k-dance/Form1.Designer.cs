namespace k_k_dance
{
    partial class FormAutorisation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEntrance = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 35);
            this.textBox1.TabIndex = 0;
            // 
            // buttonEntrance
            // 
            this.buttonEntrance.BackColor = System.Drawing.Color.Thistle;
            this.buttonEntrance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEntrance.Location = new System.Drawing.Point(131, 212);
            this.buttonEntrance.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEntrance.Name = "buttonEntrance";
            this.buttonEntrance.Size = new System.Drawing.Size(125, 41);
            this.buttonEntrance.TabIndex = 1;
            this.buttonEntrance.Text = "войти";
            this.buttonEntrance.UseVisualStyleBackColor = false;
            this.buttonEntrance.Click += new System.EventHandler(this.buttonEntrance_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "админ",
            "пользователь"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "админ",
            "пользователь"});
            this.comboBox1.Location = new System.Drawing.Point(91, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 36);
            this.comboBox1.TabIndex = 2;
            // 
            // FormAutorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(368, 336);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonEntrance);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAutorisation";
            this.Text = "авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonEntrance;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

