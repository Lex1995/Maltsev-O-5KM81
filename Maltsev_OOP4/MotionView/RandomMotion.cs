using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionModel;

namespace MotionView
{
    /// <summary>
    /// класс для создания случайных уравнений движения
    /// </summary>
    public static class RandomMotion
    {
        /// <summary>
        /// Случайное число
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Метод для реализации рандомных параметров движения
        /// </summary>
        /// <returns>объект класса MotionBase</returns>
        public static MotionBase GetRandomMotion()
        {
            int typeMotion = _random.Next(0, 3);

            //TODO switch case - исправлено
            //TODO: Duplication - исправлено

            switch (typeMotion)
            {
                case 0:
                {
                    return GetRandomUniformMotion();
                }

                case 1:
                {
                    return GetRandomUniformAcceleratedMotion();
                }

                case 2:
                {
                    return GetRandomOscillatoryMotion();
                }

                default:
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Метод получения случайных дробных значений из целых
        /// </summary>
        /// <param name="minValue">минимальная граница диапазона</param>
        /// <param name="maxValue">максимальная граница диапазона</param>
        /// <param name="divider">делитель</param>
        /// <returns>случайное дробное число</returns>
        private static double GetRandomDouble(int minValue, 
                                    int maxValue, int divider)
        {
            double randomDouble = Convert.ToDouble
                (_random.Next(minValue, maxValue) / divider);

            return randomDouble;
        }

        /// <summary>
        /// Получение случайных параметров равномерного движения
        /// </summary>
        /// <returns>Параметры равномерного движения</returns>
        private static MotionBase GetRandomUniformMotion()
        {
            var randomUniformMotion = new UniformMotion
            {
                InitialCoordinate = GetRandomDouble(-1000, 1000, 100),
                Time = GetRandomDouble(0, 1000, 100),
                Speed = GetRandomDouble(-1000, 1000, 100)
            };

            return randomUniformMotion;
        }

        /// <summary>
        /// Получение случайных параметров равноускоренного движения
        /// </summary>
        /// <returns>Параметры равноускоренного движения</returns>
        private static MotionBase GetRandomUniformAcceleratedMotion()
        {
            var randomUniformAcceleratedMotion =
                        new UniformAcceleratedMotion
                        {
                            InitialCoordinate =
                                GetRandomDouble(-1000, 1000, 100),
                            Time = GetRandomDouble(0, 1000, 100),
                            InitialSpeed =
                                GetRandomDouble(-1000, 1000, 100),
                            Acceleration =
                                GetRandomDouble(-1000, 1000, 100)
                        };

            return randomUniformAcceleratedMotion;
        }

        /// <summary>
        /// Получение случайных параметров колебательного движения
        /// </summary>
        /// <returns>Параметры колебательного движения</returns>
        private static MotionBase GetRandomOscillatoryMotion()
        {
            var randomOscillatoryMotion = new OscillatoryMotion
            {
                InitialCoordinate =
                            GetRandomDouble(-1000, 1000, 100),
                Time = GetRandomDouble(0, 1000, 100),
                Magnitude = GetRandomDouble(0, 1000, 100),
                Frequency = GetRandomDouble(0, 10000, 100),
                InitialPhase = GetRandomDouble(-1800, 1800, 10)
            };

            return randomOscillatoryMotion;
        }
    }
}
