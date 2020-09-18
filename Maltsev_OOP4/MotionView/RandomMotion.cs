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
            MotionBase motion = new UniformMotion();

            int typeMotion = _random.Next(0, 3);

            if (typeMotion == 0)
            {
                double randomTime = Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomInitialCoordinate = 
                    Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomSpeed =
                    Convert.ToDouble(_random.Next(0, 10000) / 100);

                motion = new UniformMotion(randomInitialCoordinate, randomSpeed, randomTime);
            }

            if (typeMotion == 1)
            {
                double randomTime = Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomInitialCoordinate =
                    Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomSpeed =
                    Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomAcceleration=
                    Convert.ToDouble(_random.Next(0, 10000) / 100);

                motion = new UniformAcceleratedMotion(randomInitialCoordinate,
                    randomTime, randomSpeed, randomAcceleration);
            }

            if (typeMotion == 2)
            {
                double randomTime = Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomInitialCoordinate =
                    Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomFrequency= Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomMagnitude = Convert.ToDouble(_random.Next(0, 10000) / 100);
                double randomInitialPhase = Convert.ToDouble(_random.Next(-180, 180) / 100);

                motion = new OscillatoryMotion(randomMagnitude, randomFrequency, 
                        randomInitialPhase, randomInitialCoordinate, randomTime);
            }

            return motion;

        }



    }
}
