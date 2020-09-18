using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionModel;
using System.Windows.Forms;
using System.ComponentModel;


namespace MotionView
{
    /// <summary>
    /// класс для создания таблицы определенного формата
    /// </summary>
    public static class DataMotionView
    {
        /// <summary>
        /// Метод создания таблицы заданного формата
        /// </summary>
        /// <param name="motions">лист объектов уравнений движения</param>
        /// <param name="dataGridView">Созданная таблица</param>
        public static void CreateTable(BindingList<MotionBase> motions,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = motions;

            dataGridView.Columns[0].HeaderText = "Начальная координата";
            dataGridView.Columns[1].HeaderText = "Время";
            dataGridView.Columns[2].HeaderText = "Расчетная координата";
            dataGridView.Columns[3].HeaderText = "Тип движения";

            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 100;

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
