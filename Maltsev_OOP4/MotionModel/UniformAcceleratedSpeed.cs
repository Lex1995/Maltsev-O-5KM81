﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionModel
{
    /// <summary>
    /// класс, описывающий равноускоренное движение
    /// </summary>
    [Serializable]
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
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    throw new ArgumentException(
                        "Значение не может быть неопределенным");
                }

                _initialSpeed = value;
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
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    throw new ArgumentException(
                        "Значение не может быть неопределенным");
                }

                _acceleration = value;
            }
        }

        /// <summary>
        /// Рассчитанная координата
        /// </summary>
        public override double CalculatedCoordinate
        {
            get
            {
                return base.InitialCoordinate + _initialSpeed * base.Time +
                        _acceleration * Math.Pow(base.Time, 2) / 2;
            }
        }

        /// <summary>
        /// Описание вида движения
        /// </summary>
        public override string Description
        {
            get
            {
                return "Равноускоренное движение";
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

        /// <summary>
        /// Конструктор равноускоренного движения через базовые параметры
        /// </summary>
        /// <param name="initialCoordinate">Начальная координата</param>
        /// <param name="time">время</param>
        public UniformAcceleratedMotion
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
