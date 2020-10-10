using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionModel
{
    /// <summary>
    /// класс, описывающий колебательное движение
    /// </summary>
    [Serializable]
    public class OscillatoryMotion: MotionBase
    {

        #region Fields

        /// <summary>
        /// Амплитуда
        /// </summary>
        private double _magnitude;

        /// <summary>
        /// Начальная фаза
        /// </summary>
        private double _initialPhase;

        /// <summary>
        /// Частота
        /// </summary>
        private double _frequency;

        #endregion

        #region Properties

        /// <summary>
        /// Амплитуда
        /// </summary>
        public double Magnitude
        {
            get
            {
                return _magnitude;
            }

            set
            {
                _magnitude = NanAndNegativeChecking(value, "Амплитуда");
            }
        }

        /// <summary>
        /// Начальная фаза
        /// </summary>
        public double InitialPhase
        {
            get
            {
                return _initialPhase;
            }

            set
            {
                _initialPhase = NanChecking(value, "Начальная фаза");
            }
        }

        /// <summary>
        /// Частота
        /// </summary>
        public double Frequency
        {
            get
            {
                return _frequency;
            }

            set
            {
                _frequency = NanAndNegativeChecking(value, "Частота");
            }
        }

        /// <summary>
        /// Рассчитанная координата
        /// </summary>
        public override double CalculatedCoordinate
        {
            get
            {
                return base.InitialCoordinate + _magnitude * Math.Sin(
                        2*Math.PI * _frequency + _initialPhase * Math.PI / 180);
            }
        }

        /// <summary>
        /// Описание типа движения
        /// </summary>
        public override string Description
        {
            get
            {
                return "Колебательное движение";
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// конструктор для колебательного движения
        /// </summary>
        /// <param name="magnitude">амплитуда</param>
        /// <param name="frequency">частота</param>
        /// <param name="initialPhase">начальная фаза</param>
        /// <param name="time">время</param>
        public OscillatoryMotion
            (
            double magnitude,
            double frequency,
            double initialPhase,
            double initialCoordinate,
            double time
            )
        {
            InitialCoordinate = initialCoordinate;
            Magnitude = magnitude;
            Frequency = frequency;
            InitialPhase = initialPhase;
            Time = time;
        }

        /// <summary>
        /// пустой конструктор для колебательного движения 
        /// </summary>
        public OscillatoryMotion() { }

        /// <summary>
        /// Конструктор для колебательного движения через базовые параметры
        /// </summary>
        /// <param name="initialCoordinate">Начальная координата</param>
        /// <param name="time">Время</param>
        public OscillatoryMotion
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
