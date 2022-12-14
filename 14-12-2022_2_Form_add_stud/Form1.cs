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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            f.ShowDialog();

        }

        private void button1_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    class Student 
        {
        public string? _name;
        public string? _soneme;
        public string _group;

        Student() { }
        Student (string? name, string? soneme, string group)
        {
            _name = name;
            _soneme = soneme;
            _group = group;
        }

        public override string ToString()
        {
            return $"Имя:{_name}, Фамилия:{_soneme}, Группа:{_group}";
        }
    }
}