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
       protected  int value1,
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

        

    }
    public class Time : Triad
    {             
        public Time(int initValue1, int initValue2, int initValue3) :
           base(initValue1, initValue2, initValue3)
        {
            
                value1 = initValue1;
                value2 = initValue2;
                value3 = initValue3;
            
            
        }
        public int Value1
        {
            get
            {
                return value1;
            }
            set
            {
                // проверяем, что число положительное
                if (value > 0 && value < 24)
                {
                    value1 = value;
                }
                else
                {
                    MessageBox.Show("Неккоректный ввод");
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
                if (value > 0 && value < 60)
                {
                    value2 = value;
                }
                else
                {
                    MessageBox.Show("Неккоректный ввод");
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
                if (value > 0 && value < 60)
                {
                    value3 = value;
                }
                else
                {
                    MessageBox.Show("Неккоректный ввод");
                }
            }
        }

        

        // Задает случайные значения в диапазоне от 0 до 50 

        public void RandomFill()
        {
            Random random = new Random();
            value1 = random.Next(0, 23);
            value2 = random.Next(0, 59);
            value3 = random.Next(0, 59);
        }

        public void SumSecond(int initValue)
        {
            value3 = value3 + initValue;
            while (value3 > 59)
            {
                value2++;
                value3 -= 60;
                if (value2 > 59)
                {
                    value1++;
                    value2 -= 60;
                    if (value1 > 23)
                    {
                        value1 = 0;
                    }
                }
            }
        }
        public void SumMinute(int initValue)
        {                     
            value2 = value2 + initValue;
            while(value2>59)
            {
                value1++;
                value2 -= 60;
                if (value1 > 23)
                {
                    value1-= 24;
                }
            }
        }
        public void Increment1()
        {
            if (value1 < 23) 
            {
                value1++; 
            }     
            else value1 = 0;
        }
        public void Increment2()
        {

            if (value2 < 59)
            {
                value2++;
            }
            else 
            { 
                value2 = 0; 
                value1++; 
            }

        }
        public void Increment3()
        {
            if (value3 < 59)
            {
                value3++;
            }
            else
            {
                value3 = 0;
               
            }
        }

    }
}
