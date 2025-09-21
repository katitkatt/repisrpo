namespace k_k_dance
{
    partial class FormTt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dancestylesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсоваяDataSet = new k_k_dance.курсоваяDataSet();
            this.timetableTableAdapter = new k_k_dance.курсоваяDataSetTableAdapters.timetableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dancestylesidDataGridViewTextBoxColumn,
            this.traineridDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.roomnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // dancestylesidDataGridViewTextBoxColumn
            // 
            this.dancestylesidDataGridViewTextBoxColumn.DataPropertyName = "dance_styles_id";
            this.dancestylesidDataGridViewTextBoxColumn.HeaderText = "dance_styles_id";
            this.dancestylesidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dancestylesidDataGridViewTextBoxColumn.Name = "dancestylesidDataGridViewTextBoxColumn";
            this.dancestylesidDataGridViewTextBoxColumn.Width = 125;
            // 
            // traineridDataGridViewTextBoxColumn
            // 
            this.traineridDataGridViewTextBoxColumn.DataPropertyName = "trainer_id";
            this.traineridDataGridViewTextBoxColumn.HeaderText = "trainer_id";
            this.traineridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traineridDataGridViewTextBoxColumn.Name = "traineridDataGridViewTextBoxColumn";
            this.traineridDataGridViewTextBoxColumn.Width = 125;
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class_id";
            this.classidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.Width = 125;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomnumberDataGridViewTextBoxColumn
            // 
            this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number";
            this.roomnumberDataGridViewTextBoxColumn.HeaderText = "room_number";
            this.roomnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
            this.roomnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataMember = "timetable";
            this.timetableBindingSource.DataSource = this.курсоваяDataSet;
            // 
            // курсоваяDataSet
            // 
            this.курсоваяDataSet.DataSetName = "курсоваяDataSet";
            this.курсоваяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timetableTableAdapter
            // 
            this.timetableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "room_numb";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 28);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 174);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 28);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "end_time";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.button2.Location = new System.Drawing.Point(228, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.button1.Location = new System.Drawing.Point(228, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 28);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "start_time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "class_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "trainer_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ds_id";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(395, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(168)))), ((int)(((byte)(213)))));
            this.button3.Location = new System.Drawing.Point(94, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "ds_id";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(107, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 28);
            this.textBox7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "trainer_id";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(107, 72);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 28);
            this.textBox8.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(107, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 28);
            this.textBox9.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "class_id";
            // 
            // FormTt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTt";
            this.Text = "FormTt";
            this.Load += new System.EventHandler(this.FormTt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсоваяDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private курсоваяDataSet курсоваяDataSet;
        private System.Windows.Forms.BindingSource timetableBindingSource;
        private курсоваяDataSetTableAdapters.timetableTableAdapter timetableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dancestylesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
    }
}