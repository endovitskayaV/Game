using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Painter
    {
        public static void Money(Graphics g)
        {
            g.DrawImage(Image.FromFile("money.png"), new Rectangle(new Point(220, 8), new Size(18, 18)));
        }

        public void Animal(string name)
        { }

        public void Grass(int length, int width)
        { }
    }
}
