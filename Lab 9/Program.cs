using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Я вас категорически приветствую!");
                Console.WriteLine("Введите два числа:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции над этими числами:\n\t1 - сложение\n\t2 - вычитание\n\t3 - умножение\n\t4 - частное");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c < 1 || c > 4)
                    throw new ArgumentOutOfRangeException();

                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Ваше решение: {0}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ваше решение: {0}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ваше решение: {0}", a * b);
                            break;
                        }
                    case 4:
                        {
                            
                            double d = ((double)a) / b;
                            Console.WriteLine("Ваше решение: {0:F2}", d);
                            break;
                        }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введено значение операции за пределами допустимого диапазона");
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Ошибка! Деление на 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
