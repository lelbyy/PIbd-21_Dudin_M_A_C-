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
    public partial class FormParking : Form
    {
        private readonly Parking<Plane> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Plane>(pictureBox1.Width, pictureBox1.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBox1.Image = bmp;
        }

        private void buttonPlaneParking_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
                
            if (parking + plane!=-1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonFighterParking_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Fighter(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + plane!=-1)
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
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBox1.Text);
                var plane = parking - index;
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetCar(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
