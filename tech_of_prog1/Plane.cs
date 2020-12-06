using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace tech_of_prog1
{	
        public class Plane : Vehicle
        {
            
            protected readonly int planeWidth = 210;
            
            protected readonly int planeHeight = 120;

            protected readonly char separator = ';';


        public Plane(int maxSpeed, float weight, Color mainColor)
            {
                MaxSpeed = maxSpeed;
                Weight = weight;
                MainColor = mainColor;
            }

        public Plane(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }


        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int
           planeHeight)
            {
                MaxSpeed = maxSpeed;
                Weight = weight;
                MainColor = mainColor;
                this.planeWidth = planeWidth;
                this.planeHeight = planeHeight;
            }
            public override void MoveTransport(Direction direction)
            {
            int LeftSide = 25;
            int RightSide = 15;
            int step = Convert.ToInt32(MaxSpeed * 100 / Weight);
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step >= LeftSide)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step >= RightSide)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
            public override void DrawTransport(Graphics g)
            {
            Pen pen = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(MainColor);

            //нос самолета
            g.DrawLine(pen, _startPosX, _startPosY + 50, _startPosX + 70, _startPosY + 30);
            g.DrawLine(pen, _startPosX, _startPosY + 50, _startPosX + 70, _startPosY + 70);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 30, _startPosX + 70, _startPosY + 70);

            //korpus
            g.DrawLine(pen, _startPosX + 70, _startPosY + 30, _startPosX + 210, _startPosY + 30);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 70, _startPosX + 210, _startPosY + 70);
                


            Point point1 = new Point(_startPosX, _startPosY + 50);
            Point point2 = new Point(_startPosX + 30, _startPosY + 30);
            Point point3 = new Point(_startPosX + 210, _startPosY + 30);
            Point point4 = new Point(_startPosX + 210, _startPosY + 70);
            Point point5 = new Point(_startPosX + 30, _startPosY + 70);
            Point point6 = new Point(_startPosX, _startPosY + 50);
            Point[] corpuse = { point1, point2, point3, point4, point5, point6 };
            g.FillPolygon(myBrush, corpuse);


            //крылья

            //verh
            g.DrawLine(pen, _startPosX + 120, _startPosY + 30, _startPosX + 150, _startPosY - 20);
            g.DrawLine(pen, _startPosX + 150, _startPosY - 20, _startPosX + 170, _startPosY - 20);
            g.DrawLine(pen, _startPosX + 170, _startPosY - 20, _startPosX + 150, _startPosY + 30);

            //niz
            g.DrawLine(pen, _startPosX + 120, _startPosY + 70, _startPosX + 150, _startPosY + 120);
            g.DrawLine(pen, _startPosX + 150, _startPosY + 120, _startPosX + 170, _startPosY + 120);
            g.DrawLine(pen, _startPosX + 170, _startPosY + 120, _startPosX + 150, _startPosY + 70);
            Point point7 = new Point(_startPosX + 120, _startPosY + 30);
            Point point8 = new Point(_startPosX + 150, _startPosY - 20);
            Point point9 = new Point(_startPosX + 170, _startPosY - 20);
            Point point10 = new Point(_startPosX + 150, _startPosY + 70);
            Point[] krilo_verh = { point7, point8, point9, point10 };

            Point point11 = new Point(_startPosX + 120, _startPosY + 70);
            Point point12 = new Point(_startPosX + 150, _startPosY + 120);
            Point point13 = new Point(_startPosX + 170, _startPosY + 120);
            Point point14 = new Point(_startPosX + 150, _startPosY + 70);
            Point[] krilo_niz = { point11, point12, point13, point14 };
            g.FillPolygon(myBrush, krilo_verh);
            g.FillPolygon(myBrush, krilo_niz);



            //хвост

            g.DrawLine(pen, _startPosX + 200, _startPosY + 30, _startPosX + 210, _startPosY + 5);
            g.DrawLine(pen, _startPosX + 210, _startPosY + 5, _startPosX + 210, _startPosY + 95);
            g.DrawLine(pen, _startPosX + 210, _startPosY + 95, _startPosX + 200, _startPosY + 70);
            Point point15 = new Point(_startPosX + 200, _startPosY + 30);
            Point point16 = new Point(_startPosX + 210, _startPosY + 5);
            Point point17 = new Point(_startPosX + 210, _startPosY + 95);
            Point point18 = new Point(_startPosX + 200, _startPosY + 70);
            Point[] hvost = { point15, point16, point17, point18 };
            g.FillPolygon(myBrush, hvost);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
 }

