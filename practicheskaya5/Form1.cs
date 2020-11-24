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
        
        //Умножить значения с числом
        private void button6_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(incValue.Text, out int inc))
            {
                int firstNumber = Convert.ToInt32(First1.Text);
                int secondNumber = Convert.ToInt32(Second2.Text);
                int thirdNumber = Convert.ToInt32(Third3.Text);
                int chislo = Convert.ToInt32(incValue.Text);
                ClassLibrary1.Triad triadNumbers = new Triad(firstNumber, secondNumber, thirdNumber);
                int Mult = triadNumbers * chislo;
                Resultat2.Text = Mult.ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
            
        }

        //Ввести значения
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(pervoe.Text, out int first) && Int32.TryParse(vtoroe.Text, out int second) && Int32.TryParse(tretye.Text, out int third))
            {

                triad.Value1 = first;
                triad.Value2 = second;
                triad.Value3 = third;
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        //Сгенерировать значения
        private void button8_Click(object sender, EventArgs e)
        {
            triad.RandomFill();
            First1.Text = triad.Value1.ToString();
            Second2.Text = triad.Value2.ToString();
            Third3.Text = triad.Value3.ToString();
        }

        //Увеличить на значение
        private void button5_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(incValue.Text, out int inc))
            {
                int firstNumber = Convert.ToInt32(First1.Text);
                int secondNumber = Convert.ToInt32(Second2.Text);
                int thirdNumber = Convert.ToInt32(Third3.Text);
                int chislo = Convert.ToInt32(incValue.Text);
                ClassLibrary1.Triad triadNumbers = new Triad(firstNumber, secondNumber, thirdNumber);
                int sum = triadNumbers + chislo;
                Resultat1.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать класс Triad (тройка положительных чисел). " +
                " Использовать класс Triad (тройка положительных чисел). " +
                "Разработать операцию инкремента увеличения полей на заданное число." +
                "Разработать операцию для умножения триады с числом. \nБароян Гиоргий\nИСП-31");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //вывести значения
        private void button1_Click_1(object sender, EventArgs e)
        {

            First1.Text = triad.Value1.ToString();
            Second2.Text = triad.Value2.ToString();
            Third3.Text = triad.Value3.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
