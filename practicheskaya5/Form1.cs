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
        ClassLibrary1.Time time = new Time(5, 5, 5);


        private void button6_Click(object sender, EventArgs e)
        {

        }

        //Ввести значения
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(pervoe.Text, out int first) && Int32.TryParse(vtoroe.Text, out int second) && Int32.TryParse(tretye.Text, out int third))
            {

                time.Value1 = first;
                time.Value2 = second;
                time.Value3 = third;
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        //Сгенерировать значения
        private void button8_Click(object sender, EventArgs e)
        {
            time.RandomFill();
            First1.Text = time.Value1.ToString();
            Second2.Text = time.Value2.ToString();
            Third3.Text = time.Value3.ToString();
        }

        //Увеличить на значение
        private void button5_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(incValue1.Text, out int inc))
            {
                time.SumSecond(inc);
                Third3.Text = time.Value3.ToString();
                Second2.Text = time.Value2.ToString();
                First1.Text = time.Value1.ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Использовать класс Triad (тройка положительных чисел). " +
                "Определить класс- наследник Time с полями: час, минута, секунда." +
                " Переопределить методы увеличения полей на 1 и определить методы увеличения на n секунд m минут." +
                "\nБароян Гиоргий\nИСП-31");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //вывести значения
        private void button1_Click_1(object sender, EventArgs e)
        {

            First1.Text = time.Value1.ToString();
            Second2.Text = time.Value2.ToString();
            Third3.Text = time.Value3.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Увеличить часы на 1
        private void button2_Click(object sender, EventArgs e)
        {
            time.Increment1();
            Second2.Text = time.Value2.ToString();
            First1.Text = time.Value1.ToString();
            Third3.Text = time.Value3.ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(incValue2.Text, out int inc))
            {
                time.SumMinute(inc);
                Second2.Text = time.Value2.ToString();
                First1.Text = time.Value1.ToString();
                Third3.Text = time.Value3.ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        private void pervoe_TextChanged(object sender, EventArgs e)
        {

        }
        //Увеличить минуты на 1
        private void button3_Click(object sender, EventArgs e)
        {
            time.Increment2();
            Second2.Text = time.Value2.ToString();
            First1.Text = time.Value1.ToString();
            Third3.Text = time.Value3.ToString();

        }
        //Увеличить секунды на 1
        private void button4_Click(object sender, EventArgs e)
        {
            time.Increment3();
            Second2.Text = time.Value2.ToString();
            First1.Text = time.Value1.ToString();
            Third3.Text = time.Value3.ToString();
        }

        private void First1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
