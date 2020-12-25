using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_of_prog1
{
    public class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Fighter && y is Fighter)
            {
                return ComparerBomberPlane((Fighter)x, (Fighter)y);
            }
            if (x is Plane && y is Fighter)
            {
                return 1;
            }
            if (x is Fighter && y is Plane)
            {
                return -1;
            }
            if (x is Plane && y is Plane)
            {
                return ComparerPlane((Plane)x, (Plane)y);
            }
            return 0;
        }

        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }

            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerBomberPlane(Fighter x, Fighter y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Guns != y.Guns)
            {
                return x.Guns.CompareTo(y.Guns);
            }
            if (x.Nose != y.Nose)
            {
                return x.Nose.CompareTo(y.Nose);
            }
            return 0;
        }
    }
}
