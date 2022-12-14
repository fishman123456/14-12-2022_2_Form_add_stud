namespace _14_12_2022_2_Form_add_stud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_Load = new System.Windows.Forms.Button();
            this.button2_Save = new System.Windows.Forms.Button();
            this.button3_Add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Load
            // 
            this.button1_Load.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1_Load.Location = new System.Drawing.Point(303, 25);
            this.button1_Load.Name = "button1_Load";
            this.button1_Load.Size = new System.Drawing.Size(100, 50);
            this.button1_Load.TabIndex = 0;
            this.button1_Load.Text = "Загрузить";
            this.button1_Load.UseVisualStyleBackColor = true;
            this.button1_Load.Click += new System.EventHandler(this.button1_Load_Click);
            // 
            // button2_Save
            // 
            this.button2_Save.Enabled = false;
            this.button2_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2_Save.Location = new System.Drawing.Point(303, 107);
            this.button2_Save.Name = "button2_Save";
            this.button2_Save.Size = new System.Drawing.Size(100, 50);
            this.button2_Save.TabIndex = 1;
            this.button2_Save.Text = "Сохранить";
            this.button2_Save.UseVisualStyleBackColor = true;
            this.button2_Save.Click += new System.EventHandler(this.button2_Save_Click);
            // 
            // button3_Add
            // 
            this.button3_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3_Add.Location = new System.Drawing.Point(303, 186);
            this.button3_Add.Name = "button3_Add";
            this.button3_Add.Size = new System.Drawing.Size(100, 50);
            this.button3_Add.TabIndex = 2;
            this.button3_Add.Text = "Добавить";
            this.button3_Add.UseVisualStyleBackColor = true;
            this.button3_Add.Click += new System.EventHandler(this.button3_Add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 315);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1_Exit
            // 
            this.button1_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1_Exit.Location = new System.Drawing.Point(303, 265);
            this.button1_Exit.Name = "button1_Exit";
            this.button1_Exit.Size = new System.Drawing.Size(100, 50);
            this.button1_Exit.TabIndex = 3;
            this.button1_Exit.Text = "Выход";
            this.button1_Exit.UseVisualStyleBackColor = true;
            this.button1_Exit.Click += new System.EventHandler(this.button1_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 387);
            this.Controls.Add(this.button1_Exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3_Add);
            this.Controls.Add(this.button2_Save);
            this.Controls.Add(this.button1_Load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_Load;
        private Button button2_Save;
        private Button button3_Add;
        private TextBox textBox1;
        private Button button1_Exit;
    }
}