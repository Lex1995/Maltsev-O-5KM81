using System;
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
            //TODO: Дубль - исправлено
            _motion = new UniformMotion(_motion.InitialCoordinate, 
                                                _motion.Time);

            SetVisible(_motion);
        }

        /// <summary>
        /// Событие при нажатии кнопки равноускоренного движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonUniformAcceleratedMotion_CheckedChanged(
                                object sender, EventArgs e)
        {
            //TODO: Дубль - исправлено
            _motion = new UniformAcceleratedMotion(_motion.InitialCoordinate, 
                                                        _motion.Time);

            SetVisible(_motion);
        }

        /// <summary>
        /// Событие при нажатии кнопки колебательного движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonOscillatoryMotion_CheckedChanged(
                            object sender, EventArgs e)
        {
            //TODO: Дубль - исправлено
            _motion = new OscillatoryMotion(_motion.InitialCoordinate, 
                                                _motion.Time);

            SetVisible(_motion);
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
            _isCorrect = true;

            //TODO: Адресность исключений - исправлено

            if (_motion is UniformMotion)
            {
                _motion = EnterUniformMotionParameteres();
            }

            if (_motion is UniformAcceleratedMotion)
            {
                _motion = EnterUnifromAcceleratedMotionParameteres();
            }

            if (_motion is OscillatoryMotion)
            {
                _motion = EnterOscillatoryMotionParameteres();
            }

            DisplayData();
           
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
        /// Установка видимых текстовых полей в зависимости от типа движения
        /// </summary>
        /// <param name="motion">уравнение движения</param>
        private void SetVisible(MotionBase motion)
        {
            TexBoxSpeed.Visible = false;
            TextBoxAcceleration.Visible = false;
            TextBoxFrequency.Visible = false;
            TextBoxInitialPhase.Visible = false;
            TextBoxMagnitude.Visible = false;

            labelFrequency.Visible = false;
            labelInitialPhase.Visible = false;
            labelMagnitude.Visible = false;
            labelSpeed.Visible = false;
            labelAcceleration.Visible = false;
            labelPressEnter.Visible = true;

            if (motion is UniformMotion)
            {
                TexBoxSpeed.Visible = true;
                labelSpeed.Visible = true;
            }

            if (motion is UniformAcceleratedMotion)
            {
                TexBoxSpeed.Visible = true;
                TextBoxAcceleration.Visible = true;
                labelSpeed.Visible = true;
                labelAcceleration.Visible = true;
            }

            if (motion is OscillatoryMotion)
            {
                TextBoxFrequency.Visible = true;
                TextBoxInitialPhase.Visible = true;
                TextBoxMagnitude.Visible = true;
                labelFrequency.Visible = true;
                labelInitialPhase.Visible = true;
                labelMagnitude.Visible = true;
            }
        }

        /// <summary>
        /// Метод для ввода значений равномерного движения
        /// </summary>
        /// <returns></returns>
        private UniformMotion EnterUniformMotionParameteres()
        {
            var motionParameters = new UniformMotion();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    motionParameters.InitialCoordinate = 
                        EnterDoubleValue(TextBoxInitialCoordinate.Text);
                }),

                 new Action(() =>
                {
                    motionParameters.Time =
                        EnterDoubleValue(TextBoxInitialTime.Text);
                }),
                 
                new Action(() =>
                {
                    motionParameters.Speed = 
                        EnterDoubleValue(TexBoxSpeed.Text);
                })
            };

            actions.ForEach(SetValue);
            return motionParameters;
        }

        /// <summary>
        /// Ввод параметров равноускоренного движения
        /// </summary>
        /// <returns></returns>
        private UniformAcceleratedMotion EnterUnifromAcceleratedMotionParameteres()
        {
            var motionParameters = new UniformAcceleratedMotion();
            var actions = new List<Action>()
            {
                                new Action(() =>
                {
                    motionParameters.InitialCoordinate = 
                        EnterDoubleValue(TextBoxInitialCoordinate.Text);
                }),

                new Action(() =>
                {
                    motionParameters.Time = 
                        EnterDoubleValue(TextBoxInitialTime.Text);
                }),

                new Action(() =>
                {
                    motionParameters.InitialSpeed = 
                        EnterDoubleValue(TexBoxSpeed.Text);
                }),
                new Action(() =>
                {
                    motionParameters.Acceleration = 
                        EnterDoubleValue(TextBoxAcceleration.Text);
                })


            };

            actions.ForEach(SetValue);
            return motionParameters;
        }

        /// <summary>
        /// Ввод параметров колебательного движения
        /// </summary>
        /// <returns></returns>
        private OscillatoryMotion EnterOscillatoryMotionParameteres()
        {
            var motionParameters = new OscillatoryMotion();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    motionParameters.InitialCoordinate = 
                        EnterDoubleValue(TextBoxInitialCoordinate.Text);
                }),

                new Action(() =>
                {
                    motionParameters.Time = 
                        EnterDoubleValue(TextBoxInitialTime.Text);
                }),
               
                new Action(() =>
                {
                    motionParameters.Frequency = 
                        EnterDoubleValue(TextBoxFrequency.Text);
                }),

                new Action(() =>
                {
                    motionParameters.InitialPhase = 
                        EnterDoubleValue(TextBoxInitialPhase.Text);
                }),

                new Action(() =>
                {
                    motionParameters.Magnitude = 
                        EnterDoubleValue(TextBoxMagnitude.Text);
                }),
                
            };

            actions.ForEach(SetValue);
            return motionParameters;
        }

        /// <summary>
        /// Ввод дробного числа с заменой разделителя
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        private double EnterDoubleValue(string inputText)
        {
            var buffer = double.Parse(inputText.Replace('.', ','));

            return buffer;
        }

        /// <summary>
        /// Задание значений при пользовательском вводе
        /// </summary>
        /// <param name="action">Делегат со значением параметра</param>
        private void SetValue(Action action)
        {
            try
            {
                action.Invoke();
                return;
            }

            catch (Exception exception)
            {
                _isCorrect = false;

                if (exception is ArgumentException)
                {
                    MessageBox.Show(exception.Message);
                }

                if (exception is FormatException)
                {
                    MessageBox.Show(exception.Message + " Введите число.");
                }
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
