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
    /// Класс, описывающий форму для поиска объектов
    /// </summary>
    public partial class DataSearchForm : Form
    {

        /// <summary>
        /// Список сущностей из основной формы
        /// </summary>
        private BindingList<MotionBase> _motions;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="motions"></param>
        public DataSearchForm(BindingList<MotionBase> motions)
        {
            InitializeComponent();

            _motions = motions;
        }

        /// <summary>
        /// Список с результатами поиска
        /// </summary>
        private BindingList<MotionBase> _motionSearch =
            new BindingList<MotionBase>();

        /// <summary>
        /// Событие при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataSearchForm_Load(object sender, EventArgs e)
        {
            DataMotionView.CreateTable(_motionSearch, DataSerchMotionVew);

            RadioButtonInitialCoordinate.Checked = true;
        }

        /// <summary>
        /// Метод поиска по значению одного из параметров
        /// </summary>
        private void Search()
        {
            _motionSearch.Clear();

            try
            {
                if (RadioButtonInitialCoordinate.Checked)
                {
                    foreach (var row in _motions)
                    {
                        if (row.InitialCoordinate ==
                            Convert.ToDouble(TextBoxInsertValue.Text))
                        {
                            _motionSearch.Add(row);
                        }
                    }
                }

                else
                {
                    foreach (var row in _motions)
                    {
                        if (row.Time ==
                            Convert.ToDouble(TextBoxInsertValue.Text))
                        {
                            _motionSearch.Add(row);
                        }
                    }
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message} " +
                     $"\nВведите десятичное число!(Через запятую)");
            }
        }

        /// <summary>
        /// Изменение атрибута поиска на время 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonInitialCoordinate_CheckedChanged(object sender, EventArgs e)
        {
            _motionSearch.Clear();
        }

        /// <summary>
        /// Событие запуска поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// Ввод данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxInsertValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Search();
            }
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataSerchMotionVew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
