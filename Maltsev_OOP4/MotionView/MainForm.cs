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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            #if !DEBUG
            AddRandomMotionButton.Visible=false;
            #endif
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

        /// <summary>
        /// Событие генерации рандомного уравнения движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRandomMotionButton_Click(object sender, EventArgs e)
        {
            _motions.Add(RandomMotion.GetRandomMotion());
        }

        /// <summary>
        /// Событие вызова сериализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter= "lekha files (*.lekha)|*.lekha";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var binaryFormatter = new BinaryFormatter();
                    var filePath = saveFileDialog.FileName;

                    using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                    {
                        binaryFormatter.Serialize(fileStream, _motions);
                        MessageBox.Show("Файл сохранен!");
                    }

                }
            }
        }

        /// <summary>
        /// Событие инициализации загрузки файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter= "lekha files (*.lekha)|*.lekha";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                        {
                            var newMotions = (BindingList<MotionBase>)formatter.
                                Deserialize(fileStream);

                            foreach (var motion in newMotions)
                            {
                                _motions.Add(motion);
                            }
                        }
                    }

                    catch
                    {
                        MessageBox.Show("Файл поврежден, " +
                            "невозможно загрузить!");
                    }
                }
            }
        }
    }
}
