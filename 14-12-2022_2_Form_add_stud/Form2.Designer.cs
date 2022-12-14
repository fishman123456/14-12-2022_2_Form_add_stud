namespace _14_12_2022_2_Form_add_stud
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Name = new System.Windows.Forms.TextBox();
            this.textBox2_Soneme = new System.Windows.Forms.TextBox();
            this.comboBox1_Group = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа";
            // 
            // textBox1_Name
            // 
            this.textBox1_Name.Location = new System.Drawing.Point(12, 53);
            this.textBox1_Name.Name = "textBox1_Name";
            this.textBox1_Name.Size = new System.Drawing.Size(200, 23);
            this.textBox1_Name.TabIndex = 3;
            this.textBox1_Name.TextChanged += new System.EventHandler(this.textBox1_Name_TextChanged);
            // 
            // textBox2_Soneme
            // 
            this.textBox2_Soneme.Location = new System.Drawing.Point(12, 136);
            this.textBox2_Soneme.Name = "textBox2_Soneme";
            this.textBox2_Soneme.Size = new System.Drawing.Size(200, 23);
            this.textBox2_Soneme.TabIndex = 4;
            this.textBox2_Soneme.TextChanged += new System.EventHandler(this.textBox2_Soneme_TextChanged);
            // 
            // comboBox1_Group
            // 
            this.comboBox1_Group.FormattingEnabled = true;
            this.comboBox1_Group.Location = new System.Drawing.Point(12, 244);
            this.comboBox1_Group.Name = "comboBox1_Group";
            this.comboBox1_Group.Size = new System.Drawing.Size(200, 23);
            this.comboBox1_Group.TabIndex = 5;
            this.comboBox1_Group.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Group_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата Рождения";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1_Group);
            this.Controls.Add(this.textBox2_Soneme);
            this.Controls.Add(this.textBox1_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1_Name;
        private TextBox textBox2_Soneme;
        private ComboBox comboBox1_Group;
        private DateTimePicker dateTimePicker1;
        private Label label4;
    }
}