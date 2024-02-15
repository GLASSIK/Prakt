using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая___8___Обработка_строк_____задание___1__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем фамилии из текстовых полей
            string lastName1 = lastNametextBox1.Text;
            string lastName2 = lastNametextBox2.Text;

            // Получаем длины фамилий
            int length1 = lastName1.Length;
            int length2 = lastName2.Length;

            // Сравниваем длины и выводим результат
            if (length1 > length2)
            {
                resultlabel3.Text = $"Фамилия {lastName1} длиннее фамилии {lastName2}.";
            }
            else if (length1 < length2)
            {
                resultlabel3.Text = $"Фамилия {lastName2} длиннее фамилии {lastName1}.";
            }
            else
            {
                resultlabel3.Text = "Длины фамилий равны.";
            }
        }
    }
}
