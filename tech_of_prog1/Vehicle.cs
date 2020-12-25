using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace tech_of_prog1
{
    public abstract class Vehicle : ITransport
    {
        
        protected int _startPosX;
       
        protected int _startPosY;
        
        protected int _pictureWidth;
        
        protected int _pictureHeight;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
        _startPosX = x;
        _startPosY = y;
        _pictureWidth = width;
        _pictureHeight = height;
        }
        public void SetPosition(int x, int y)
        {
            _startPosX = x;
            _startPosY = y;
        }

        public void SetMainColor(Color color)
        {        
            MainColor = color;
        }

        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }

}
