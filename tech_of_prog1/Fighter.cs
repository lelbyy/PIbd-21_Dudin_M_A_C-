using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace tech_of_prog1
{
    public class Fighter : Plane
    {

        public Color DopColor { private set; get; }
        public bool Guns { private set; get; }
       
        public bool Nose { private set; get; }

        public Fighter(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool guns, bool nose) : base(maxSpeed, weight, mainColor, 210, 120)
        {
            DopColor = dopColor;
            Guns = guns;
            Nose = nose;
           
        }
       
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(DopColor);
            //пушки
            base.DrawTransport(g);
            if (Guns)
            {
                g.DrawLine(pen, _startPosX + 105, _startPosY + 20, _startPosX + 125, _startPosY + 20);
                g.DrawLine(pen, _startPosX + 105, _startPosY + 80, _startPosX + 125, _startPosY + 80);

                g.DrawLine(pen, _startPosX + 112, _startPosY + 15, _startPosX + 130, _startPosY + 15);
                g.DrawLine(pen, _startPosX + 112, _startPosY + 85, _startPosX + 130, _startPosY + 85);
            }
            if (Nose)
            {
                g.DrawLine(pen, _startPosX, _startPosY + 50, _startPosX -10, _startPosY + 50);
            }
        }
    }
}
