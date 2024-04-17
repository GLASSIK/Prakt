using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp46
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int n = 0;
                try
                {

                    if (textBox1.Text.Trim() == "")
                    {
                        throw new Exception("Вы не ввели Наименование товара");
                    }
                    n++;
                    if (textBox2.Text.Trim() == "")
                    {
                        throw new Exception("Вы не ввели Наименование страны импортёра");
                    }
                    n++;
                    if (textBox3.Text.Trim() == "")
                    {
                        throw new Exception("Вы не ввели Обьём годового импорта");
                    }
                    n++;
                    if (textBox3.Text.Trim() == "")
                    {
                        throw new Exception("Вы не ввели Стоимость товара за еденицу");
                    }
                    n++;
                    if (Convert.ToInt32(textBox3.Text) < 1 || Convert.ToInt32(textBox3.Text) > 10000)
                    {
                        throw new Exception("Обьём годового импорта не может быть меньше нуля и больше 1000");
                    }
                    n++;
                    if (Convert.ToInt32(textBox4.Text) < 0.1 || Convert.ToInt32(textBox4.Text) > 10000)
                    {
                        throw new Exception("Стоимость товара за еденицу не может быть меньше нуля целых одного десятого и больше 10000");
                    }
                }
                catch (FormatException)
                {
                    if (n == 4)
                    {
                        MessageBox.Show("Обьём годового импорта введены не коректно");
                        e.Cancel = true;
                    }
                    else if (n == 5)
                    {
                        MessageBox.Show("Стоимость товара за еденицу введены не коректно");
                        e.Cancel = true;
                    }
                }
                catch (Exception ex)
                {
                    if (n == 0)
                    {
                        textBox1.Focus();
                    }
                    else if (n == 1)
                    {
                        textBox2.Focus();
                    }
                    else if (n == 2)
                    {
                        textBox3.Focus();
                    }
                    else if (n == 3)
                    {
                        textBox4.Focus();
                    }
                    else if (n == 4)
                    {
                        textBox2.Focus();
                    }
                    else if (n == 5)
                    {
                        textBox3.Focus();
                    }
                    MessageBox.Show(ex.Message);
                    e.Cancel = true;
                }
            }
        }
    }
}
