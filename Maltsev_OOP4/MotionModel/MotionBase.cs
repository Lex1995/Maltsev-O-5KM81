using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionModel
{
    /// <summary>
    /// базовый класс для различных видов движения
    /// </summary>
    public abstract class MotionBase
    {

        #region Fields

        /// <summary>
        /// время
        /// </summary>
        private double _time;

        /// <summary>
        /// начальная координата
        /// </summary>
        private double _initialCoordinate;

        #endregion

        #region Properties

        /// <summary>
        /// начальная координата
        /// </summary>
        public double InitialCoordinate
        {
            get
            {
                return _initialCoordinate;
            }
            set
            {
                _initialCoordinate = ValueChecking(value);
            }
        }

        /// <summary>
        /// время
        /// </summary>
        public double Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = ValueChecking(value);
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// проверка на неопределенность значения и на отрицательное значеник
        /// </summary>
        /// <param name="value">переданное значение</param>
        /// <returns>проверенное значение</returns>
        protected double ValueChecking (double value)
        {

            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                throw new ArgumentException(
                    "Значение не может быть неопределенным");
            }

            if (value < 0)
            {
                throw new ArgumentException(
                    "Значение не может быть отрицательным");
            }

            return value;
        }

        /// <summary>
        /// Расчет уравнения движения 
        /// </summary>
        /// <returns></returns>
        public abstract double MotionCalculation();

        #endregion
    }
}
