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

        private static int homeAnimalWidth = 50;
        private static int wildAnimalWidth = 50;
        private static int homeAnimalHeight = 50;
        private static int wildAnimalHeight = 50;

        private static Point[,] layoyt=new Point[7, 11];

        public static List<Point> homeAnimalCoordinates;



        public static void GoneWildAnimal(Graphics g, WildAnimal.Names name)
        {
            string fileName = name.ToString() + "Traces.png";
           // g.DrawImage(Image.FromFile(fileName), homeAnimalCoordinates[index].X, homeAnimalCoordinates[index].Y, homeAnimalWidth, homeAnimalHeight);

        }

        public static void Money(Graphics g, int x0, int y0, int width, int deltaSize)
        {
            g.DrawImage(Image.FromFile("money.png"), new Rectangle(new Point(x0 + width, y0), new Size(18 / deltaSize, 18 / deltaSize)));
        }

        public static void HomeAnimal(Graphics g, HomeAnimal.Names name, int index)
        {
            string fileName = name.ToString() + ".png";
            g.DrawImage(Image.FromFile(fileName), homeAnimalCoordinates[index].X, homeAnimalCoordinates[index].Y, homeAnimalWidth, homeAnimalHeight); 
        }

        public static void WildAnimal(Graphics g, WildAnimal.Names name, int index)
        {
            string fileName = name.ToString() + ".png";
            g.DrawImage(Image.FromFile(fileName), homeAnimalCoordinates[index].X, homeAnimalCoordinates[index].Y-wildAnimalHeight, wildAnimalWidth, wildAnimalHeight);


        }

        public static void Background(Graphics g, int x0, int y0, int height, int width)
        {
            // g.DrawImage(Image.FromFile("grass.jpg"), new Rectangle(x0, y0, width, height));
            g.FillRectangle(new SolidBrush(Color.FromArgb(245, 222, 179)), 0, 0, 160, height);


            //SolidBrush brushGreen = new SolidBrush(Color.Green);
            //SolidBrush brushFrame = new SolidBrush(Color.FromArgb(139, 134, 78));


            //g.FillRectangle(new SolidBrush(Color.FromArgb(205, 179, 139)), new Rectangle(x0, y0, width, height));
            /*
            //забор еще, который на 4 части делит поле
            int placeHomeAnimalNumberInWidth = (width - 180) / (homeAnimalWidth + wildAnimalWidth);
            int placeHomeAnimalNumberInHeight = (height) / (homeAnimalHeight + wildAnimalHeight);

            //11*7

            int currX = 180;
            int currY = 0 + wildAnimalHeight;

            for (int i = 0; i < placeHomeAnimalNumberInHeight; i++)
            {
                if (i != 3)
                {
                    for (int j = 0; j < placeHomeAnimalNumberInWidth; j++)
                    {
                        if (j != 5)
                        {
                            g.FillRectangle(brushFrame, currX, currY, homeAnimalWidth, homeAnimalHeight);
                            g.FillRectangle(brushGreen, currX + 3, currY + 3, homeAnimalWidth - 6, homeAnimalHeight - 6);
                        }
                        currX += wildAnimalWidth + homeAnimalWidth;
                    }
                }

                currY += wildAnimalHeight + homeAnimalHeight;
                currX = 180;

            }*/
        }

        public static void MakeLayout()
        {
            
            int currX = 180;
            int currY = 0 + wildAnimalHeight;

            for (int i = 0; i < 7; i++)
            {
                if (i != 3)
                {
                    for (int j = 0; j <11; j++)
                    {
                        if (j != 5)
                        {
                            layoyt[i, j] = new Point(currX, currY);
                        }
                        currX += wildAnimalWidth + homeAnimalWidth;
                    }
                }

                currY += wildAnimalHeight + homeAnimalHeight;
                currX = 180;

            }

            homeAnimalCoordinates = new List<Point>{
            new Point (layoyt[0,0].X, layoyt[0,0].Y), //hen
            new Point (layoyt[0,1].X, layoyt[0,1].Y), //hen
            new Point (layoyt[0,6].X, layoyt[0,6].Y), //cock
            new Point (layoyt[0,7].X, layoyt[0,7].Y), //cock
            new Point (layoyt[4,0].X, layoyt[4,0].Y), //pig
            new Point (layoyt[4,6].X, layoyt[4,6].Y) //duck

        };

        }


    }
}
