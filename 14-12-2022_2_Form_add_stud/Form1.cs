namespace _14_12_2022_2_Form_add_stud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Load_Click(object sender, EventArgs e)
        {

        }

        private void button2_Save_Click(object sender, EventArgs e)
        {

        }

        private void button3_Add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
           // f.ShowDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
               listBoxStudents.Items.Add(f.ST);
            }
           
        }

        private void button1_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
   
    
}