using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApp46
{
    public partial class Form1 : Form
    {
        struct produkt
        {
           public string naim;
           public string stran;
           public int koli;
            public int stoim;
        }
        List<produkt> produkt1 = new List<produkt>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (textBox1.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Вы не ввели наименование");
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не ввели наименование страны импортёра");
                textBox2.Focus();
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не ввели обьём партии");
                textBox3.Focus();
            }
            else if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не ввели стоймость за еденицу товара");
                textBox4.Focus();
            }
            else if (Convert.ToInt32(textBox3.Text)<0)
            {
                MessageBox.Show("годовой импорт не может быть меньше 0");
                textBox3.Focus();
            }
            else if (Convert.ToInt32(textBox4.Text) < 0)
            {
                MessageBox.Show("стоимость за еденицу товара не может быть меньше 0");
                textBox4.Focus();
            }
            else
            {
                produkt p = new produkt();
                p.naim = textBox1.Text;
                p.stran = textBox2.Text;
                p.koli = Convert.ToInt32(textBox3.Text);
                p.stoim = Convert.ToInt32(textBox4.Text);
                produkt1.Add(p);
               
               
                matr.RowCount = produkt1.Count;
                for (int i = 0; i < produkt1.Count; i++)
                {
                    matr[0, i].Value = produkt1[i].naim;
                    matr[1, i].Value = produkt1[i].stran;
                    matr[2, i].Value = produkt1[i].koli.ToString();
                    matr[3, i].Value = produkt1[i].stoim.ToString();
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            */
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
            {
                produkt p = new produkt();
                p.naim = f.textBox1.Text;
                p.stran = f.textBox2.Text;
                p.koli = Convert.ToInt32(f.textBox3.Text);
                p.stoim = Convert.ToInt32(f.textBox4.Text);
                produkt1.Add(p);


                matr.RowCount = produkt1.Count;
                for (int i = 0; i < produkt1.Count; i++)
                {
                    matr[0, i].Value = produkt1[i].naim;
                    matr[1, i].Value = produkt1[i].stran;
                    matr[2, i].Value = produkt1[i].koli.ToString();
                    matr[3, i].Value = produkt1[i].stoim.ToString();
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (matr.CurrentRow == null)
            {
                MessageBox.Show("Вы не выделили строку");
            }
            else
            {
                DialogResult result = MessageBox.Show("Точно удалить элемент?", "Точно удалить элемент?", MessageBoxButtons.OKCancel,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    int n = matr.CurrentRow.Index;
                    produkt1.RemoveAt(n);
                    matr.RowCount = produkt1.Count;
                    for (int i = 0; i < produkt1.Count; i++)
                    {
                        matr[0, i].Value = produkt1[i].naim;
                        matr[1, i].Value = produkt1[i].stran;
                        matr[2, i].Value = produkt1[i].koli.ToString();
                        matr[3, i].Value = produkt1[i].stoim.ToString();
                    }
                }

            }
        }

        private void matr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void matr_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter("1.txt") ;
            for (int i = 0;i < produkt1.Count; i++)
            {
                wr.WriteLine(matr[0, i].Value.ToString());
                wr.WriteLine(matr[1, i].Value.ToString());
                wr.WriteLine(matr[2, i].Value.ToString());
                wr.WriteLine(matr[3, i].Value.ToString());
            }
            wr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            produkt1.Clear();
            StreamReader read = new StreamReader("1.txt");
            while(read.EndOfStream== false)
            {
                produkt p = new produkt();
                p.naim = read.ReadLine();
                p.stran = read.ReadLine();
                p.koli = Convert.ToInt32(read.ReadLine());
                p.stoim = Convert.ToInt32(read.ReadLine());
                produkt1.Add(p);
            }
            matr.RowCount = produkt1.Count;
            for (int i = 0; i < produkt1.Count; i++)
            {
                matr[0, i].Value = produkt1[i].naim;
                matr[1, i].Value = produkt1[i].stran;
                matr[2, i].Value = produkt1[i].koli.ToString();
                matr[3, i].Value = produkt1[i].stoim.ToString();
            }
            read.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < produkt1.Count; i++)
            {
                for (int j = 0; j < produkt1.Count - i - 1; j++)
                {
                    if (produkt1[j].koli < produkt1[j + 1].koli)
                    {
                        produkt p = produkt1[j];
                        produkt1[j] = produkt1[j + 1];
                        produkt1[j + 1] = p;

                    }
                }
            }
            dataGridView1.RowCount = produkt1.Count;
            for (int i = 0;i < produkt1.Count; i++)
            {
                dataGridView1[0,i].Value = produkt1[i].naim;
                dataGridView1[1, i].Value = produkt1[i].stran;
                dataGridView1[2, i].Value = produkt1[i].koli.ToString();
                dataGridView1[3, i].Value = produkt1[i].stoim.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            int n = matr.CurrentRow.Index;
            f.textBox1.Text = matr[0, n].Value.ToString();
            f.textBox2.Text = matr[1, n].Value.ToString();
            f.textBox3.Text = matr[2, n].Value.ToString();
            f.textBox4.Text = matr[3, n].Value.ToString();

            if (f.ShowDialog() == DialogResult.OK)
            {
                int d = matr.CurrentRow.Index;
                produkt p = new produkt();
                p.naim = f.textBox1.Text;
                p.stran = f.textBox2.Text;
                p.koli = Convert.ToInt32(f.textBox3.Text);
                p.stoim = Convert.ToInt32(f.textBox4.Text);
                produkt1[d] = p;
                matr.RowCount = produkt1.Count;
                for (int i = 0; i < produkt1.Count; i++)
                {
                    matr[0, i].Value = produkt1[i].naim;
                    matr[1, i].Value = produkt1[i].stran;
                    matr[2, i].Value = produkt1[i].koli.ToString();
                    matr[3, i].Value = produkt1[i].stoim.ToString();
                }
            }
        }
    }
}
