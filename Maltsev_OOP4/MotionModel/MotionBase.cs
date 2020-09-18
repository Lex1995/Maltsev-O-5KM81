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
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    throw new ArgumentException(
                        "Значение не может быть неопределенным");
                }

                _initialCoordinate = value;
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

                _time = value;
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
    }
}
