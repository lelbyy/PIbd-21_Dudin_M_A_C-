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
	public partial class FormPlane : Form
	{
		private ITransport plane;

		public FormPlane()
		{
			InitializeComponent();
		}

        public void SetCar(ITransport plane)
        {
            this.plane = plane;
            Random rnd = new Random();
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();
            
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane?.DrawTransport(gr);
            pictureBoxCars.Image = bmp;
        }
        
        private void buttonCreateFighter_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plane = new Fighter(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true, true);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
                case "buttonUp":
                    plane?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    plane?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    plane?.MoveTransport(Direction.Left);
                    break;
                    
                case "buttonRight":
                    plane?.MoveTransport(Direction.Right);
                    break;
            }
			Draw();
		}

        private void buttonCreatePlane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plane = new Plane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();
        }

        private void InitializeComponent()
		{
            this.pictureBoxCars = new System.Windows.Forms.PictureBox();
            this.buttonCreateFighter = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreatePlane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCars
            // 
            this.pictureBoxCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCars.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCars.Name = "pictureBoxCars";
            this.pictureBoxCars.Size = new System.Drawing.Size(889, 455);
            this.pictureBoxCars.TabIndex = 0;
            this.pictureBoxCars.TabStop = false;
            // 
            // buttonCreateFighter
            // 
            this.buttonCreateFighter.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateFighter.Name = "buttonCreateFighter";
            this.buttonCreateFighter.Size = new System.Drawing.Size(126, 29);
            this.buttonCreateFighter.TabIndex = 1;
            this.buttonCreateFighter.Text = "Создать истрибитель";
            this.buttonCreateFighter.UseVisualStyleBackColor = true;
            this.buttonCreateFighter.Click += new System.EventHandler(this.buttonCreateFighter_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::tech_of_prog1.Properties.Resources.strDown;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(805, 355);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::tech_of_prog1.Properties.Resources.Left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(769, 391);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::tech_of_prog1.Properties.Resources.Down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(805, 391);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::tech_of_prog1.Properties.Resources.Right1;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(842, 391);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreatePlane
            // 
            this.buttonCreatePlane.Location = new System.Drawing.Point(156, 12);
            this.buttonCreatePlane.Name = "buttonCreatePlane";
            this.buttonCreatePlane.Size = new System.Drawing.Size(126, 29);
            this.buttonCreatePlane.TabIndex = 6;
            this.buttonCreatePlane.Text = "Создать самолет";
            this.buttonCreatePlane.UseVisualStyleBackColor = true;
            this.buttonCreatePlane.Click += new System.EventHandler(this.buttonCreatePlane_Click);
            // 
            // FormPlane
            // 
            this.ClientSize = new System.Drawing.Size(889, 455);
            this.Controls.Add(this.buttonCreatePlane);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateFighter);
            this.Controls.Add(this.pictureBoxCars);
            this.Name = "FormPlane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).EndInit();
            this.ResumeLayout(false);

		}
    }
}
