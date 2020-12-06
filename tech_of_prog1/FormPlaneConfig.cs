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
	public partial class FormPlaneConfig : Form
	{
		Vehicle plane = null;
		private event Action<Vehicle> eventAddPlane;

		

		public FormPlaneConfig()
		{
			InitializeComponent();

			foreach (var item in groupColors.Controls)
			{
				if (item is Panel)
				{
					((Panel)item).MouseDown += panelColor_MouseDown;
				}
			}

			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void DrawPlane()
		{
			if (plane != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
				Graphics gr = Graphics.FromImage(bmp);
				plane.SetPosition(30, 25, pictureBoxPlane.Width, pictureBoxPlane.Height);
				plane.DrawTransport(gr);
				pictureBoxPlane.Image = bmp;
			}
		}

		public void AddEvent(Action<Vehicle> ev)
		{
			if (eventAddPlane == null)
			{
				eventAddPlane = new Action<Vehicle>(ev);
			}
			else
			{
				eventAddPlane += ev;
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
                    plane = new Plane((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.Blue);
                    break;
				case "Истребитель":
					plane = new Fighter((int)numericUpDownMaxSpeed.Value,
				   (int)numericUpDownWeight.Value, Color.Red, Color.Red, checkBoxGuns.Checked, checkBoxNose.Checked);
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
	

		/// Принимаем основной цвет
		private void labelColor_DragEnter(object sender, DragEventArgs e)
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

		private void labelMainColor_DragDrop(object sender, DragEventArgs e)
		{
			plane?.SetMainColor((Color)e.Data.GetData(typeof(Color)));
			DrawPlane();
		}

		/// Принимаем дополнительный цвет
		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (plane is Fighter)
			{
				Fighter fighter = (Fighter)plane;
				fighter.SetDopColor((Color)(e.Data.GetData(typeof(Color))));
				plane = fighter;
				DrawPlane();
			}
		}

	

        private void buttonAdd_Click(object sender, EventArgs e)
        {
			eventAddPlane?.Invoke(plane);
			Close();			
		}      
    }
}
