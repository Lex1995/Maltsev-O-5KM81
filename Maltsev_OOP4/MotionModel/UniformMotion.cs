using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionModel
{
    /// <summary>
    /// класс, описывающий равномерное движение
    /// </summary>
    public class UniformMotion: MotionBase
    {

        #region Fields

        /// <summary>
        /// скорость
        /// </summary>
        private double _speed;

        #endregion

        #region Properties

        /// <summary>
        /// скорость
        /// </summary>
        public double Speed
        {  
            get
            {
                return _speed;
            }

            set
            {
                _speed = ValueChecking(value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// конструктор для равномерного движения
        /// </summary>
        /// <param name="initialCoordinate">начальная координата</param>
        /// <param name="speed">скорость</param>
        /// <param name="time">время</param>
        public UniformMotion
            (
            double initialCoordinate,
            double speed,
            double time
            )
        {
            InitialCoordinate = initialCoordinate;
            Speed = speed;
            Time = time;
        }

        /// <summary>
        /// пустой конструктор для равномерного движения
        /// </summary>
        public UniformMotion() { }

        #endregion

        #region Methods

        /// <summary>
        /// расчет координаты при равномерном движении
        /// </summary>
        /// <returns>значение координаты</returns>
        public override double MotionCalculation()
        {
            return InitialCoordinate + (Speed * Time);
        }
        #endregion
    }
}
