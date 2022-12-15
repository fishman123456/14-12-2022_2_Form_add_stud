using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_12_2022_2_Form_add_stud
{
    public partial class Form2 : Form
    {
        public Student ST = new Student();
        public Form2()
        {
            InitializeComponent();
            string[] group = { "ЗЭПА", "ЗГП", "ЗМЧМ" };
            comboBox1_Group.Items.AddRange(group);
        }

        private void textBox1_Name_TextChanged(object sender, EventArgs e)
        {
            ST.Name=textBox1_Name.Text;
        }

        private void textBox2_Soneme_TextChanged(object sender, EventArgs e)
        {
            ST.Fname=textBox2_Soneme.Text;
        }

        private void comboBox1_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            ST.Group = comboBox1_Group.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ST.BirthDay = dateTimePicker1.Value;
        }

        private void button1_Save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
