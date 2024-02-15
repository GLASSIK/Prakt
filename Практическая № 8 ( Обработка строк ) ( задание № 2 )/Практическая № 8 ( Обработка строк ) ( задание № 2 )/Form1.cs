using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая___8___Обработка_строк_____задание___2__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получить слова из текстовых полей
            string firstWord = textBox1.Text;
            string secondWord = textBox2.Text;

            // Получить первую букву первого слова
            int firstWordFirstLetter = firstWord[0];

            // Получить последнюю букву второго слова
            int secondWordLastLetter = secondWord[secondWord.Length - 1];

            // Сравнить буквы
            if (firstWordFirstLetter == secondWordLastLetter)
            {
                // Слова начинаются на одну букву
                label3.Text = "Да";
            }
            else
            {
                // Слова не начинаются на одну букву
                label3.Text = "Нет";
            }
        }
    }
}
