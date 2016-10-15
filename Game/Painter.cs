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

        public static void GrownAnimal(Graphics g)
        { }

        public static void GoneWildAnimal(Graphics g)
        { }

        public static void Money(Graphics g, int x0, int y0, int width, int delta)
        {
            g.DrawImage(Image.FromFile("money.png"), new Rectangle(new Point(x0+width, y0), new Size(18/delta, 18/delta)));
        }

        public static void HomeAnimal(HomeAnimal.Names name, HomeAnimal.LifeStages lifeStage)
        { }

        public static void WildAnimal(WildAnimal.Names name)
        { }

        public static  void Grass(Graphics g, int x0, int y0, int height, int width)
        {
            g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(x0, y0, width, height));
        }
    }
}
