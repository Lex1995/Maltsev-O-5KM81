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
    public partial class MainForm : Form
    {
        /// <summary>
        /// основной лист параметров уравнений движения 
        /// </summary>
        private BindingList<MotionBase> _motions = new BindingList<MotionBase>();

        /// <summary>
        /// событие при загрузке формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие при запуске формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataMotionView.CreateTable(_motions, DataMotionsView);
        }

        /// <summary>
        /// Событие вызова расчета движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMotion_Click(object sender, EventArgs e)
        {
            var motion = new MotionForm();

            if (motion.ShowDialog() == DialogResult.OK)
            {
                _motions.Add(motion.MotionDone);
            }
        }

        /// <summary>
        /// Событие удаления расчета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveMotionButton_Click(object sender, EventArgs e)
        {
            var deleteCount = DataMotionsView.SelectedRows.Count;

            for (int i=0; i<deleteCount; i++)
            {
                _motions.RemoveAt(DataMotionsView.SelectedRows[0].Index);
            }
        }
    }
}
