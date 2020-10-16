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
    [Serializable]
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
                _initialCoordinate = NanChecking(value, "Начальная координата");
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
               _time = NanAndNegativeChecking(value, "Время");
            }
        }

        /// <summary>
        /// Рассчитанная координата
        /// </summary>
        public virtual double CalculatedCoordinate { get;  }
        
        
        /// <summary>
        /// Описание вида движения
        /// </summary>
        public virtual String Description { get;  }

        #endregion

        #region Methods

        /// <summary>
        /// Проверка на неопределенность и отрицательное значение
        /// </summary>
        /// <param name="value">число</param>
        /// <returns>проверенное числовое значение</returns>
        protected double NanAndNegativeChecking(double value, string propertyName)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                throw new ArgumentException(propertyName +
                    " не может быть неопределенным");
            }

            if (value < 0)
            {
                throw new ArgumentException(propertyName + 
                    " не может быть отрицательным");
            }

            return value;
        }

        /// <summary>
        /// Проверка на неопределенное значение
        /// </summary>
        /// <param name="value">число</param>
        /// <returns>проверенное числовое значение</returns>
        protected double NanChecking(double value, string propertyName)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                throw new ArgumentException(
                    propertyName + "не может быть неопределенным");
            }

            return value;
        }

        #endregion
    }
}
