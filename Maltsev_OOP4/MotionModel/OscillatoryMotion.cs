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
                _magnitude = ValueChecking(value);
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
                _initialPhase = ValueChecking(value);
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
                _frequency = ValueChecking(value);
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

        #endregion

        #region Methods

        /// <summary>
        /// расчет координаты при колебательном движении
        /// </summary>
        /// <returns>полученное значение координаты</returns>
        public override double MotionCalculation()
        {
            double angleSpeed = 2 * Math.PI * Frequency;
            double initialPhaseInRadians = InitialPhase * Math.PI / 180;
            //TODO: RSDN - исправлено
            return InitialCoordinate + Magnitude * Math.Sin(angleSpeed * Time + 
                                                            initialPhaseInRadians);
        }

        #endregion
    }
}
