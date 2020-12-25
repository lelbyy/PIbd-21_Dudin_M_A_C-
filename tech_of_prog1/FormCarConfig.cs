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
	public partial class FormCarConfig : Form
	{
		Vehicle plane = null;
		private event PlaneDelegate eventAddCar;

		public FormCarConfig()
		{
			InitializeComponent();

			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void DrawPlane()
		{
			if (plane != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
				Graphics gr = Graphics.FromImage(bmp);
				plane.SetPosition(5, 5, pictureBoxCar.Width, pictureBoxCar.Height);
				plane.DrawTransport(gr);
				pictureBoxCar.Image = bmp;
			}
		}

		public void AddEvent(PlaneDelegate ev)
		{
			if (eventAddCar == null)
			{
				eventAddCar = new PlaneDelegate(ev);
			}
			else
			{
				eventAddCar += ev;
			}
		}


		private void labelPlane_MouseDown(object sender, MouseEventArgs e)
		{
			labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move |
		   DragDropEffects.Copy);
		}

		private void labelFighter_MouseDown(object sender, MouseEventArgs e)
		{
			labelFighter.DoDragDrop(labelFighter.Text, DragDropEffects.Move |
		   DragDropEffects.Copy);
		}

		private void panelPlane_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		private void panelPlane_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Самолет":
					plane = new Plane(100, 500, Color.Black);
					break;
				case "Истребитель":
					plane = new Fighter(100, 500, Color.Red, Color.Black, true, true);
					break;
			}
			DrawPlane();
		}

		/// Отправляем цвет с панели
		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}

		/// Проверка получаемой информации (ее типа на соответствие требуемому)
		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		/// Принимаем основной цвет
		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			plane?.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
			DrawPlane();
		}

		/// Принимаем дополнительный цвет
		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (plane is Fighter)
			{
				Fighter thisShip = (Fighter)plane;
				thisShip.SetDopColor((Color)(e.Data.GetData(typeof(Color))));
				plane = thisShip;
				DrawPlane();
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			eventAddCar?.Invoke(plane);
			Close();
		}
	}
}
