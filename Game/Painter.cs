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
        public static void Money(Graphics g, int moneyLblX0, int moneyLblY0, int moneyLblWidth, int delta)
        {
            
            g.DrawImage(Image.FromFile("money.png"), new Rectangle(new Point(moneyLblX0+moneyLblWidth, moneyLblY0), new Size(18/delta, 18/delta)));
        }

        public void Animal(string name)
        { }

        public void Grass(int length, int width)
        { }
    }
}
