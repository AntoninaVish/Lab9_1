using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int x;//first num
                int y;// second num
                double z=0;//resul
                int [] opr = {1,2,3,4}; //code operation
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число. X=");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
                
            }
            Console.WriteLine("Введите код операции: \n1 - сложение \n2 - вычитание \n3 - произведение \n4 - частное");

                Console.Write("Ваш выбор:");
              int codeOpr;
            try
            {
                codeOpr = Convert.ToInt32(Console.ReadLine());
                int code = opr[-1 + codeOpr];

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Некорректный ввод.");
                Console.ReadKey();
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка. Нет операции с выбранным номером.");
                Console.ReadKey();
                return;
            }
            try
            {

                if (codeOpr == 1)
                {
                z = x + y;
                }
                else if (codeOpr == 2)
                {
                z = x - y;
                }
                else if (codeOpr == 3)
                {
                z = x * y;
                }
                else if (codeOpr == 4)
                {  
                z=x / y; 
                }
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Результат = {0}", z);

            Console.ReadKey();
            
           
        }
    }   

}
