using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                
                    int x;//first num
                    int y;// second num
                    double z;//resul
                    int opr; //code operation
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
            try
            {
                opr = Convert.ToInt32(Console.ReadLine());
            
                switch (opr)
                    {
                        case 1:
                            z = x + y;
                            Console.WriteLine("Результат = {0}", z);
                            break;
                        case 2:
                            z = x - y;
                            Console.WriteLine("Результат = {0}", z);
                            break;
                        case 3:
                            z = x * y;
                            Console.WriteLine("Результат = {0}", z);
                            break;
                        case 4:
                            z = (double) x / y;
                            Console.WriteLine("Результат = {0}", z);
                            break;
                    default:
                        Console.WriteLine("Ошибка. Нет операции с выбранным номером.");
                        break;
                    }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Некорректный ввод.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
