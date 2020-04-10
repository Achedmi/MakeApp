using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAppV1
{
    class Func
    {
        public static void Animate(System.Windows.Forms.Control control ,int x, int y)
        {
            if (control.Location.X == x && control.Location.Y == y)
                return;
            if (control.Location.X < x)
                while (control.Location.X != x)
                    control.Location = new System.Drawing.Point(control.Location.X - 1, control.Location.Y);
            else if(control.Location.X > x)
                while (control.Location.X != x)
                    control.Location = new System.Drawing.Point(control.Location.X + 1, control.Location.Y);
            if (control.Location.Y > y)
                while (control.Location.Y != y)
                    control.Location = new System.Drawing.Point(control.Location.X, control.Location.Y - 1);
            else if (control.Location.Y < y)
                while (control.Location.Y != y)
                    control.Location = new System.Drawing.Point(control.Location.X, control.Location.Y + 1);
        }
    }
}
