namespace _14_12_2022_2_Form_add_stud
{
    using System.Windows.Forms;
    using System.Xml.Serialization;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // фильтр для загрузки файлов
            openFileDialog1.Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*";
            // фильтр для сохранения файлов
            saveFileDialog1.Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Load_Click(object sender, EventArgs e)
        {
            // проверка на открытие папки
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            // Создаём серриализацию в XML
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
            List<Student> students =null;
            // создаем исключение чтобы программа не рушилась если не XML
            try
            {

            using (Stream fs = File.OpenRead(filename)) 
            {

                students = (List<Student>)formatter.Deserialize(fs);
            }
           
            foreach (var item in students)
            {
                listBoxStudents.Items.Add(item);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите файл XML");
            }
        }

        private void button2_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
           
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            
           

            // сделать сохранение в файл
            int number = listBoxStudents.Items.Count;
            // создаем список для сохранения обьектов
            List<Student> students = new List<Student>();   

            foreach (var item in listBoxStudents.Items)
            {
                
                students.Add((Student)item);
            }

            // объект для сериализации


            // передаем в конструктор тип класса Person
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, students);

                MessageBox.Show("Обьект записан");
            }
        }

        private void button3_Add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
           // f.ShowDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
               listBoxStudents.Items.Add(f.ST);
            }
            if (listBoxStudents.Items.Count > 0)
            {
                button1_Load.Enabled = false;
                button2_Save_Too_File.Enabled = true;
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

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
   
    
}