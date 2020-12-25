using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace tech_of_prog1
{
	public interface ITransport
	{
        void SetPosition(int x, int y, int width, int height);
        void SetPosition(int x, int y);
        void MoveTransport(Direction direction);     
        void DrawTransport(Graphics g);
        void SetMainColor(Color color);
    }
}
