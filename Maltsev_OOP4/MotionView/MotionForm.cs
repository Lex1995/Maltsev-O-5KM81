﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotionModel;

namespace MotionView
{
    /// <summary>
    /// Класс для описания формы добавления расчетов движения
    /// </summary>
    public partial class MotionForm : Form
    {

        /// <summary>
        /// Поле для создания уравнения движения
        /// </summary>
        private MotionBase _motion;

        /// <summary>
        /// Флаг для внесения данных и закрытия формы
        /// </summary>
        private bool _isCorrect;

        /// <summary>
        /// Свойство для вывода данных расчета движения
        /// </summary>
        public MotionBase MotionDone
        {
            get
            {
                    return _motion;
            }
        }

        /// <summary>
        /// Метод, инициализирующий форму
        /// </summary>
        public MotionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MotionForm_Load(object sender, EventArgs e)
        {
            _motion = new UniformMotion();
            RadioButtonUniformMotion.Checked = true;
            labelPressEnter.Visible = false;           
        }

        /// <summary>
        /// Событие при нажатии кнопки равномерного движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonUniformMotion_CheckedChanged(
                        object sender, EventArgs e)
        {
            TextBoxAcceleration.Visible = false;
            TextBoxFrequency.Visible = false;
            TextBoxInitialPhase.Visible = false;
            TextBoxMagnitude.Visible = false;
            TexBoxSpeed.Visible = true;

            labelAcceleration.Visible = false;
            labelFrequency.Visible = false;
            labelInitialPhase.Visible = false;
            labelMagnitude.Visible = false;
            labelPressEnter.Visible = true;
            labelSpeed.Visible = true;

            _motion = new UniformMotion(_motion.InitialCoordinate, 
                                                _motion.Time);
        }

        /// <summary>
        /// Событие при нажатии кнопки равноускоренного движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonUniformAcceleratedMotion_CheckedChanged(
                                object sender, EventArgs e)
        {
            TextBoxFrequency.Visible = false;
            TextBoxInitialPhase.Visible = false;
            TextBoxMagnitude.Visible = false;
            TexBoxSpeed.Visible = true;
            TextBoxAcceleration.Visible = true;

            labelFrequency.Visible = false;
            labelInitialPhase.Visible = false;
            labelMagnitude.Visible = false;
            labelPressEnter.Visible = true;
            labelSpeed.Visible = true;
            labelAcceleration.Visible = true;

            _motion = new UniformAcceleratedMotion(_motion.InitialCoordinate, 
                                                        _motion.Time);
        }

        /// <summary>
        /// Событие при нажатии кнопки колебательного движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonOscillatoryMotion_CheckedChanged(
                            object sender, EventArgs e)
        {
            TexBoxSpeed.Visible = false;
            TextBoxAcceleration.Visible = false;
            TextBoxFrequency.Visible = true;
            TextBoxInitialPhase.Visible = true;
            TextBoxMagnitude.Visible = true;

            labelFrequency.Visible = true;
            labelInitialPhase.Visible = true;
            labelMagnitude.Visible = true;
            labelSpeed.Visible = false;
            labelAcceleration.Visible = false;
            labelPressEnter.Visible = true;

            _motion = new OscillatoryMotion(_motion.InitialCoordinate, 
                                                _motion.Time);
        }


        /// <summary>
        /// Метод вывода данных на интерфейс
        /// </summary>
        private void DisplayData()
        {
            TextBoxInitialCoordinate.Text = 
                _motion.InitialCoordinate.ToString();
            TextBoxInitialTime.Text = _motion.Time.ToString();
            TextBoxCalculatedCoordinate.Text =
                _motion.CalculatedCoordinate.ToString();

            if (_motion is UniformMotion uniformMotion)
            {
                TexBoxSpeed.Text =
                    uniformMotion.Speed.ToString();
            }

            if (_motion is UniformAcceleratedMotion uniformAcceleratedMotion)
            {
                TexBoxSpeed.Text = uniformAcceleratedMotion.
                    InitialSpeed.ToString();

                TextBoxAcceleration.Text = uniformAcceleratedMotion.
                    Acceleration.ToString();
            }

            if (_motion is OscillatoryMotion oscillatoryMotion)
            {
                TextBoxMagnitude.Text =
                    oscillatoryMotion.Magnitude.ToString();

                TextBoxFrequency.Text =
                    oscillatoryMotion.Frequency.ToString();

                TextBoxInitialPhase.Text =
                    oscillatoryMotion.InitialPhase.ToString();
            }
        }

        /// <summary>
        /// Событие при вводе значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                InsertData();
            }
        }

        /// <summary>
        /// Метод ввода данных
        /// </summary>
        private void InsertData()
        {
            _isCorrect = false;

            try
            {
                //TODO: - исправлено
                _motion.InitialCoordinate =
                    Convert.ToDouble(TextBoxInitialCoordinate.Text);

                _motion.Time =
                    Convert.ToDouble(TextBoxInitialTime.Text);

                if (_motion is UniformMotion uniformMotion)
                {
                    uniformMotion.Speed =
                        Convert.ToDouble(TexBoxSpeed.Text);
                }

                if (_motion is UniformAcceleratedMotion uniformAcceleratedMotion)
                {
                    uniformAcceleratedMotion.InitialSpeed =
                        Convert.ToDouble(TexBoxSpeed.Text);

                    uniformAcceleratedMotion.Acceleration =
                        Convert.ToDouble(TextBoxAcceleration.Text);
                }

                if (_motion is OscillatoryMotion oscillatoryMotion)
                {
                    oscillatoryMotion.Magnitude =
                        Convert.ToDouble(TextBoxMagnitude.Text);

                    oscillatoryMotion.Frequency =
                        Convert.ToDouble(TextBoxFrequency.Text);

                    oscillatoryMotion.InitialPhase =
                        Convert.ToDouble(TextBoxInitialPhase.Text);
                }

                DisplayData();

                _isCorrect = true;
            }

            catch (Exception exception)
            {
                _isCorrect = false;

                MessageBox.Show($"{exception.Message} "
                    + $"\nВведите десятичное число через запятую");
            }
        }

        /// <summary>
        /// Событие добавления объекта расчета движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMotionButton_Click(object sender, EventArgs e)
        {
            InsertData();
            
            if (_isCorrect)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
                
        }

        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
