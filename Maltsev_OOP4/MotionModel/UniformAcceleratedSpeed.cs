using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionModel
{
    /// <summary>
    /// класс, описывающий равноускоренное движение
    /// </summary>
    public class UniformAcceleratedMotion: MotionBase
    {

        #region Fields

        /// <summary>
        /// начальная скорость
        /// </summary>
        private double _initialSpeed;

        /// <summary>
        /// ускорение
        /// </summary>
        private double _acceleration;

        #endregion

        #region Properties

        /// <summary>
        /// начальная скорость
        /// </summary>
        public double InitialSpeed
        {

            get
            {
                return _initialSpeed;
            }

            set
            {
                _initialSpeed = ValueChecking(value);
            }

        }

        /// <summary>
        /// ускорение
        /// </summary>
        public double Acceleration
        {

            get
            {
                return _acceleration;
            }

            set
            {
                _acceleration = ValueChecking(value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// конструктор для равноускоренного движения
        /// </summary>
        /// <param name="initialCoordinate">начальная координата</param>
        /// <param name="time">время</param>
        /// <param name="initialSpeed">начальная скорость</param>
        /// <param name="acceleration">ускорение</param>
        public UniformAcceleratedMotion
            (
            double initialCoordinate,
            double time,
            double initialSpeed,
            double acceleration
            )
        {
            InitialCoordinate = initialCoordinate;
            Time = time;
            InitialSpeed = initialSpeed;
            Acceleration = acceleration;
        }

        /// <summary>
        /// пустой конструктор для равноускоренного движения
        /// </summary>
        public UniformAcceleratedMotion() { }

        #endregion

        #region Methods

        /// <summary>
        /// расчет координаты при равноускоренном движении
        /// </summary>
        /// <returns>полученную координату</returns>
        public override double MotionCalculation()
        {
            return InitialCoordinate + InitialSpeed * Time +
                (Acceleration * Math.Pow(Time, 2) / 2);
        }

        #endregion
    }
}
