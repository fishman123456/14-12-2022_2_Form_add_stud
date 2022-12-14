namespace _14_12_2022_2_Form_add_stud
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
// Форма 1

// Кнопка 1 - добавить ст
// Кнопка 2 - сохранить ст
// Кнопка 3 - считать студента


// Форма 2
// добавить три поля
// 1 Фамилия - label, textbox
// 2 Имя
// 3 Группа  - ComboBox
// 4 Дата выбор при помощи календаря DataTimePeak
// 