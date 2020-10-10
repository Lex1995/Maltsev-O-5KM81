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
        /// Константа для максимального значения
        /// </summary>
        private const int _max = 1000;

        /// <summary>
        /// Константа для минимального значения
        /// </summary>
        private const int _min = 0;

        /// <summary>
        /// Константа шага
        /// </summary>
        private const int _step = 100;

        /// <summary>
        /// минимальное значение для формирования фазы
        /// </summary>
        private const int _minForDegree = -1800;

        /// <summary>
        /// Максимальное значение для формирования фазы
        /// </summary>
        private const int _maxForDegree = 1800;

        /// <summary>
        /// Шаг для формирования фазы
        /// </summary>
        private const int _stepForDegree = 10;

        /// <summary>
        /// Метод для реализации рандомных параметров движения
        /// </summary>
        /// <returns>объект класса MotionBase</returns>
        public static MotionBase GetRandomMotion()
        {
            int typeMotion = _random.Next(0, 3);

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
            //TODO: Собрать в константы - исправлено
            var randomUniformMotion = new UniformMotion
            {
                InitialCoordinate = GetRandomDouble(-_max, _max, _step),
                Time = GetRandomDouble(_min, _max, _step),
                Speed = GetRandomDouble(-_max, _max, _step)
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
                                GetRandomDouble(-_max, _max, _step),
                            Time = GetRandomDouble(_min, _max, _step),
                            InitialSpeed =
                                GetRandomDouble(-_max, _max, _step),
                            Acceleration =
                                GetRandomDouble(-_max, _max, _step)
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
                            GetRandomDouble(-_max, _max, _step),
                Time = GetRandomDouble(_min, _max, 100),
                Magnitude = GetRandomDouble(_min, _max, _step),
                Frequency = GetRandomDouble(_min, _max, _step),
                InitialPhase = GetRandomDouble(_minForDegree, 
                                    _maxForDegree, _stepForDegree)
            };

            return randomOscillatoryMotion;
        }
    }
}
