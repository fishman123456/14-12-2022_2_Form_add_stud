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
            this.button2_Save_Too_File = new System.Windows.Forms.Button();
            this.button3_Add = new System.Windows.Forms.Button();
            this.button1_Exit = new System.Windows.Forms.Button();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1_Load
            // 
            this.button1_Load.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1_Load.Location = new System.Drawing.Point(405, 29);
            this.button1_Load.Name = "button1_Load";
            this.button1_Load.Size = new System.Drawing.Size(100, 50);
            this.button1_Load.TabIndex = 0;
            this.button1_Load.Text = "Загрузить";
            this.button1_Load.UseVisualStyleBackColor = true;
            this.button1_Load.Click += new System.EventHandler(this.button1_Load_Click);
            // 
            // button2_Save_Too_File
            // 
            this.button2_Save_Too_File.Enabled = false;
            this.button2_Save_Too_File.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2_Save_Too_File.Location = new System.Drawing.Point(405, 111);
            this.button2_Save_Too_File.Name = "button2_Save_Too_File";
            this.button2_Save_Too_File.Size = new System.Drawing.Size(100, 50);
            this.button2_Save_Too_File.TabIndex = 1;
            this.button2_Save_Too_File.Text = "Сохранить в файл";
            this.button2_Save_Too_File.UseVisualStyleBackColor = true;
            this.button2_Save_Too_File.Click += new System.EventHandler(this.button2_Save_Click);
            // 
            // button3_Add
            // 
            this.button3_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3_Add.Location = new System.Drawing.Point(405, 190);
            this.button3_Add.Name = "button3_Add";
            this.button3_Add.Size = new System.Drawing.Size(100, 50);
            this.button3_Add.TabIndex = 2;
            this.button3_Add.Text = "Добавить";
            this.button3_Add.UseVisualStyleBackColor = true;
            this.button3_Add.Click += new System.EventHandler(this.button3_Add_Click);
            // 
            // button1_Exit
            // 
            this.button1_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1_Exit.Location = new System.Drawing.Point(405, 269);
            this.button1_Exit.Name = "button1_Exit";
            this.button1_Exit.Size = new System.Drawing.Size(100, 50);
            this.button1_Exit.TabIndex = 3;
            this.button1_Exit.Text = "Выход";
            this.button1_Exit.UseVisualStyleBackColor = true;
            this.button1_Exit.Click += new System.EventHandler(this.button1_Exit_Click);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 15;
            this.listBoxStudents.Location = new System.Drawing.Point(0, 0);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(378, 319);
            this.listBoxStudents.TabIndex = 4;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 359);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.button1_Exit);
            this.Controls.Add(this.button3_Add);
            this.Controls.Add(this.button2_Save_Too_File);
            this.Controls.Add(this.button1_Load);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1_Load;
        private Button button2_Save_Too_File;
        private Button button3_Add;
        private Button button1_Exit;
        private ListBox listBoxStudents;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}