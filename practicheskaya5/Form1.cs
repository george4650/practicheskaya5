using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace practicheskaya5
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        ClassLibrary1.Triad triad = new Triad();
        private void button6_Click(object sender, EventArgs e)
        {
            triad.Increment();
            curFirst.Text = triad.Value1.ToString();
            curSecond.Text = triad.Value2.ToString();
            curThird.Text = triad.Value3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(allFirst.Text, out int first) && Int32.TryParse(allSecond.Text, out int second) && Int32.TryParse(allThird.Text, out int third))
            {
                // пересоздаем объект с новыми характеристиками
                triad = new Triad(first, second, third);
                curFirst.Text = triad.Value1.ToString();
                curSecond.Text = triad.Value2.ToString();
                curThird.Text = triad.Value3.ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            triad.RandomFill();
            curFirst.Text = triad.Value1.ToString();
            curSecond.Text = triad.Value2.ToString();
            curThird.Text = triad.Value3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(incValue.Text, out int inc))
            {
                triad.Sum(inc);
                curFirst.Text = triad.Value1.ToString();
                curSecond.Text = triad.Value2.ToString();
                curThird.Text = triad.Value3.ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать класс Triad (тройка положительных чисел). " +
                "Создать необходимые методы и свойства. Определить метод увеличения полей на заданное число. " +
                "Создать перегруженный метод для удвоения всех полей.\nБароян Гиоргий\nИСП-31");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
