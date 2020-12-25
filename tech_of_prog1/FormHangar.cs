using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tech_of_prog1
{
    public partial class FormHangar : Form
    {
        private readonly HangarCollection hangarCollection;

        private readonly Logger logger;

        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxParking.Width,
            pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
        }

        private void ReloadLevels()
        {
            int index = listBoxHangars.SelectedIndex;
            listBoxHangars.Items.Clear();
            for (int i = 0; i < hangarCollection.Keys.Count; i++)
            {
                listBoxHangars.Items.Add(hangarCollection.Keys[i]);
            }
            if (listBoxHangars.Items.Count > 0 && (index == -1 || index >=
           listBoxHangars.Items.Count))
            {
                listBoxHangars.SelectedIndex = 0;
            }
            else if (listBoxHangars.Items.Count > 0 && index > -1 && index <
           listBoxHangars.Items.Count)
            {
                listBoxHangars.SelectedIndex = index;
            }
        }

        private void Draw()
        {        
            if (listBoxHangars.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangarCollection[listBoxHangars.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

    private void buttonTakePlane_Click(object sender, EventArgs e)
    {
        if (listBoxHangars.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
        {
            try { 
                var plane = hangarCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                     if (plane != null)
                     {
                         FormPlane form = new FormPlane();
                         form.SetCar(plane);
                         form.ShowDialog();
                         logger.Info($"Изъят самолет {plane} с места{ maskedTextBoxPlace.Text}");
                         Draw();
                     }
            }
            catch (HangarNotFoundException ex)
            {
                logger.Info($"Самолет на месте { maskedTextBoxPlace.Text} не найден");
                MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                logger.Info($"Неизвестная ошибка");
                MessageBox.Show(ex.Message, "Неизвестная ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHangars.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили ангар {textBoxHangars.Text}");
            hangarCollection.AddHangar(textBoxHangars.Text);
            ReloadLevels();
        }

        private void buttonDelHangar_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxHangars.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили ангар{ listBoxHangars.SelectedItem.ToString()}");
                    hangarCollection.DelHangar(listBoxHangars.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на ангар{ listBoxHangars.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormPlaneConfig();
            formCarConfig.AddEvent(AddPlane);
            formCarConfig.Show();
        }

        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxHangars.SelectedIndex > -1)
            {
                try
                {
                    if ((hangarCollection[listBoxHangars.SelectedItem.ToString()]) + plane)
                    {
                        Draw();
                        logger.Info($"Добавлен автомобиль {plane}");
                    }
                    else
                    {
                        MessageBox.Show("Машину не удалось поставить");
                    }
                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    logger.Info($"Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (HangarAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Info($"Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                hangarCollection[listBoxHangars.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
