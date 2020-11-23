using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace tech_of_prog1
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly List<T> _places;           
        private readonly int pictureWidth;      
        private readonly int pictureHeight;       
        private readonly int _placeSizeWidth = 430;      
        private readonly int _placeSizeHeight =160;                                                                                                   
        private readonly int parkingPlacesInRow;
        private readonly int _maxCount;
        public Parking(int picWidth, int picHeight)
        {           
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            parkingPlacesInRow = height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _maxCount = width * height;
        }

        public static bool operator +(Parking<T> p, T plane)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(plane);
            return true;
        }
       
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            T plane = p._places[index];
            p._places.RemoveAt(index);
            return plane;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(5 + i / 3 * _placeSizeWidth + 5, i % 3 *
               _placeSizeHeight + 30, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }

        }
    }
}
