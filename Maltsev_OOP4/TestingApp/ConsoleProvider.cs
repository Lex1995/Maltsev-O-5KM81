using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionModel;

namespace TestingApp
{
    /// <summary>
    /// класс для ввода данных в консоль
    /// </summary>
    public static class ConsoleProvider
    {

        /// <summary>
        /// ввод параметров равномерного движения
        /// </summary>
        /// <returns>введенные параметры движения</returns>
        public static UniformMotion EnterUniformMotionParameters()
        {
            var motionParameters = new UniformMotion();
            var actions = new List<Action>()
            {
                //TODO: RSDN - исправлено
                new Action(() =>
                {
                    Console.Write($"Скорость, м/с: (>0) ");
                    motionParameters.Speed = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Время, с: (>0) ");
                    motionParameters.Time = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Начальная координата, м: (>0) ");
                    motionParameters.InitialCoordinate = EnterDoubleValue();
                })
            };

                actions.ForEach(SetValue);
                return motionParameters;
        }

        /// <summary>
        /// Ввод параметров при равноускоренном движении
        /// </summary>
        /// <returns>введенные параметры движения</returns>
        public static UniformAcceleratedMotion EnterUniformAcceleratedMotionParameters()
        {
            var motionParameters = new UniformAcceleratedMotion();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write($"Начальная скорость, м/с: (>0) ");
                    motionParameters.InitialSpeed = EnterDoubleValue();
                }),
                new Action(() =>
                {
                    Console.Write($"Ускорение, м/с2: (>0) ");
                    motionParameters.Acceleration = EnterDoubleValue();
                }),

                new Action(() =>
                {
                    Console.Write($"Начальная координата, м: (>0) ");
                    motionParameters.InitialCoordinate = EnterDoubleValue();
                }),

                new Action(() =>
                {
                    Console.Write($"Время, с: (>0) ");
                    motionParameters.Time = EnterDoubleValue();
                }),
            };

            actions.ForEach(SetValue);
            return motionParameters;

        }

        /// <summary>
        /// ввод параметров при равноускоренном движении
        /// </summary>
        /// <returns>введенные параметры движения</returns>
        public static OscillatoryMotion EnterOscillatoryMotionParameters()
        {
            var motionParameters = new OscillatoryMotion();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write($"Амплитуда, м: (>0) ");
                    motionParameters.Magnitude = EnterDoubleValue();
                }),

                new Action(() =>
                {
                    Console.Write($"Частота, Гц: (>0) ");
                    motionParameters.Frequency = EnterDoubleValue();
                }),

                new Action(() =>
                {
                    Console.Write($"Начальная фаза, град: (>0) ");
                    motionParameters.InitialPhase = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Начальная координата, м: (>0) ");
                    motionParameters.InitialCoordinate = EnterDoubleValue();
                }),

                new Action(() =>
                {
                    Console.Write($"Время, с: (>0) ");
                    motionParameters.Time = EnterDoubleValue();
                }),
            };

            actions.ForEach(SetValue);
            return motionParameters;
        }

        /// <summary>
        /// Ввод дробного числа с консоли и замена разделителя с точки на запятую
        /// </summary>
        /// <returns>введенное дробное число</returns>
        private static double EnterDoubleValue()
        {
            var buffer = double.Parse(Console.ReadLine().Replace('.', ','));

            return buffer;
        }

        /// <summary>
        /// Задание значений при пользовательском ввода
        /// </summary>
        /// <param name="action">делегат с заданием параметра</param>
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    if (exception is ArgumentException
                        || exception is FormatException
                        || exception is InvalidOperationException)
                    {
                        Console.WriteLine($"\n{exception.Message}\n");
                    }

               }
            }
        }

     }
}
