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
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly HangarCollection hangarCollection;
        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxParking.Width,
           pictureBoxParking.Height);
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
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
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
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Plane(100, 1000, dialog.Color);
                    if (hangarCollection[listBoxHangars.SelectedItem.ToString()] + plane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1 && maskedTextBox1.Text != "")
            {
                var plane = hangarCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox1.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetCar(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonSetFighter_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new Fighter(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if (hangarCollection[listBoxHangars.SelectedItem.ToString()] + plane)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Парковка переполнена");
                        }
                    }
                }
            }
        }
        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            hangarCollection.AddHangar(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void buttonDelHangar_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxHangars.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hangarCollection.DelParking(listBoxHangars.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddPlane_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormPlaneConfig();
            formCarConfig.AddEvent(addPlane);
            formCarConfig.Show();
        }

        private void addPlane(Vehicle plane)
        {
            if (plane != null && listBoxHangars.SelectedIndex > -1)
            {
                if ((hangarCollection[listBoxHangars.SelectedItem.ToString()]) + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }

        }
    }
}
