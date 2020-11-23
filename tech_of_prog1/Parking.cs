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
        /// Массив объектов, которые храним     
        private readonly T[] _places;
        /// Ширина окна отрисовки
        private readonly int pictureWidth;
        /// Высота окна отрисовки
        private readonly int pictureHeight;
        /// Размер парковочного места (ширина)
        private readonly int _placeSizeWidth = 430;
        /// Размер парковочного места (высота)
        private readonly int _placeSizeHeight =160;
        /// Конструктор                                                                                                 
        private readonly int parkingPlacesInRow;
        public Parking(int picWidth, int picHeight)
        {
            
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            parkingPlacesInRow = height;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static int operator +(Parking<T> p, T plane)

        {
            for (int i = 0; i < p._places.Length; i++) {
                if (p._places[i] is null) {
                    p._places[i] = plane;
                    int x = (i / p.parkingPlacesInRow) * p._placeSizeWidth;
                    int y = (i - p.parkingPlacesInRow * (i / p.parkingPlacesInRow)) * p._placeSizeHeight;
                    plane.SetPosition(x + 20, y + 25);
                    return i;
                }
            }
            return -1;
        }
       
        public static T operator -(Parking<T> p, int index)
        {
            if (index >= p._places.Length || index < 0)
            {
                return null;
            }
            T plane = p._places[index];
            p._places[index] = null;
            return plane;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
