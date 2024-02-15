using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая___8___Обработка_строк_____задание___3__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получить слово из текстового поля
            string word = textBox1.Text;

            // Определить количество гласных букв в слове
            int vowelsCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'а' || word[i] == 'о' || word[i] == 'э' || word[i] == 'и' || word[i] == 'е' || word[i] == 'ы' || word[i] == 'у' || word[i] == 'ю')
                {
                    vowelsCount++;
                }
            }

            // Определить длину слова
            int wordLength = word.Length;

            // Рассчитать процент гласных букв
            int vowelsPercent = vowelsCount * 100 / wordLength;

            // Установить текст на метке label1
            label2.Text = "Процент гласных букв: " + vowelsPercent + "%";
        }
    }
}
