using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Triad
    {
        int value1,
            value2,
            value3;

        public Triad(int initValue1, int initValue2, int initValue3)
        {
            if (initValue1 > 0 && initValue2 > 0 && initValue3 > 0)
            {
                value1 = initValue1;
                value2 = initValue2;
                value3 = initValue3;
            }
            else
            {
                MessageBox.Show("Значение должно быть положительным!");
            }
        }
        public Triad()
        {

        }

        //Свойства

        public int Value1
        {
            get
            {
                return value1;
            }
            set
            {
                // проверяем, что число положительное
                if (value > 0)
                {
                    value1 = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть положительным!");
                }
            }
        }
    
        // Значение второй переменной
      
        public int Value2
        {
            get
            {
                return value2;
            }
            set
            {
                // проверяем, что число положительное
                if (value > 0)
                {
                    value2 = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть положительным!");
                }
            }
        }
      
        // Значение третьей переменной
       
        public int Value3
        {
            get
            {
                return value3;
            }
            set
            {
                // проверяем, что число положительное
                if (value > 0)
                {
                    value3 = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть положительным!");
                }
            }
        }

        /*Методы*/
       
        // Задает случайные значения в диапазоне от 0 до 50 всем трём переменны
        
        public void RandomFill()
        {
            Random random = new Random();
            value1 = random.Next(0, 50);
            value2 = random.Next(0, 50);
            value3 = random.Next(0, 50);
        }
        

        // Увелечение всех значений на 1
    
        public void Increment()
        {


            value1*=2;
            value2*=2;
            value3*=2;


        }
        
        public void Sum(int initValue)
        {
          

            value1 += initValue;
            value2 += initValue;
            value3 += initValue;


        }
       
        public void replacement(int initValue1, int initValue2, int initValue3)
        {
            // проверяем что значение положительное
            if (initValue1 > 0 && initValue2 > 0 && initValue3 > 0)
            {
                value1 = initValue1;
                value2 = initValue2;
                value3 = initValue3;
            }
            else
            {
                MessageBox.Show("Значение должно быть положительным числом!");
            }
        }
    }
}
