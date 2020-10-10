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
    [Serializable]
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
                _speed = NanChecking(value, "Скорость"); 
            }
        }

        /// <summary>
        /// Рассчитанная координата
        /// </summary>
        public override double CalculatedCoordinate
        {
            get
            {
                return base.InitialCoordinate + (_speed * base.Time);
            }
        }

        /// <summary>
        /// Равномерное движение
        /// </summary>
        public override string Description
        {
            get
            {
                return "Равномерное движение";
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

        /// <summary>
        /// Конструктор для равномерного движения через базовые параметры
        /// </summary>
        /// <param name="initialCoordinate">начальная координата</param>
        /// <param name="time">время</param>
        public UniformMotion
            (
            double initialCoordinate, 
            double time
            )
        {
            InitialCoordinate = initialCoordinate;
            Time = time;
        }

        #endregion

    }
}
