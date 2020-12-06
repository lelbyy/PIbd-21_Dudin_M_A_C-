using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace tech_of_prog1
{
    public class Hangar<T> where T : class, ITransport
    {
        private readonly List<T> _places;           
        private readonly int pictureWidth;      
        private readonly int pictureHeight;       
        private readonly int _placeSizeWidth = 430;      
        private readonly int _placeSizeHeight =160;
        private readonly int parkingPlacesInRow;
        private readonly int _maxCount;
        public Hangar(int picWidth, int picHeight)
        {
            
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            parkingPlacesInRow = height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _maxCount = width * height;

        }
        /// <param name="h">Парковка</param>
        /// <param name="car">Добавляемый автомобиль</param>
        public static bool operator +(Hangar<T> h, T plane)

        {
            if (h._places.Count >= h._maxCount)
            {
                return false;
            }
            h._places.Add(plane);
            return true;
        }
       
        public static T operator -(Hangar<T> h, int index)
        {
            if (index < -1 || index > h._places.Count)
            {
                return null;
            }
            T plane = h._places[index];
            h._places.RemoveAt(index);
            return plane;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
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

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
    }
}
