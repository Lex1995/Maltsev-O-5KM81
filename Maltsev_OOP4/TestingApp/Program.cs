using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionModel;

namespace TestingApp
{
    /// <summary>
    /// класс для тестирования созданной библиотеки
    /// </summary>
    public class Program
    {
        /// <summary>
        /// точка вхождения в программу
        /// </summary>
        /// <param name="args">аргументы</param>
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Выберите тип движения:\n" +
                $"1 - равномерное\n" +
                $"2 - равноускоренное\n" +
                $"3 - колебательное\n");

                var motion = ChooseMotionType();
                Console.WriteLine("Ответ: " + motion.MotionCalculation());
            }          
        }

        /// <summary>
        /// Выбор типа движения
        /// </summary>
        /// <returns>параметры движения для выбранного типа</returns>
        private static MotionBase ChooseMotionType()
        {           
            while (true)
            {        
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                        {
                            Console.WriteLine("Введите параметры: ");
                            return ConsoleProvider.EnterUniformMotionParameters();
                        }

                        case 2:
                        {
                            Console.WriteLine("Введите параметры: ");
                            return ConsoleProvider.EnterUniformAcceleratedMotionParameters();
                        }

                        case 3:
                        {    
                            Console.WriteLine("Введите параметры: ");
                            return ConsoleProvider.EnterOscillatoryMotionParameters();   
                        }    

                        default:
                        {    
                            throw new ArgumentException("Такого номера нет! Введите повторно");
                        }    
                    }
                    
                }
                 
                catch (Exception exception)
                {
                    if (exception is ArgumentException
                        || exception is FormatException)
                    {
                        Console.WriteLine($"\n{exception.Message}\n");
                    }
                }
            }
        }
    }
}
