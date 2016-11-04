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

        private static Point[,] layoyt=new Point[7, 21];

        public static List<Point> homeAnimalCoordinates;



        public static void DrawGoneWildAnimal(Graphics g, WildAnimal.Names name, int width)
        {
            string fileName = name.ToString() + "Traces.png";
            g.DrawImage(Image.FromFile(fileName),width-100,200,30,30);

        }

        public static void DrawMoney(Graphics g, int x0, int y0, int width, int deltaSize)
        {
            g.DrawImage(Image.FromFile("money.png"), new Rectangle(new Point(x0 + width, y0), new Size(18 / deltaSize, 18 / deltaSize)));
        }

        public static void DrawHomeAnimal(Graphics g, HomeAnimal.Names name, int index)
        {
            string fileName = name.ToString() + ".png";
            g.DrawImage(Image.FromFile(fileName), homeAnimalCoordinates[index].X, homeAnimalCoordinates[index].Y, homeAnimalWidth, homeAnimalHeight); 
        }

        public static void DrawWildAnimal(Graphics g, WildAnimal.Names name, int index)
        {
            string fileName = name.ToString() + ".png";
            g.DrawImage(Image.FromFile(fileName), homeAnimalCoordinates[index].X, homeAnimalCoordinates[index].Y-wildAnimalHeight, wildAnimalWidth, wildAnimalHeight);


        }

        public static void DrawBackground(Graphics g, int x0, int y0, int height, int width)
        {
            // g.DrawImage(Image.FromFile("grass.jpg"), new Rectangle(x0, y0, width, height));
            g.FillRectangle(new SolidBrush(Color.FromArgb(245, 222, 179)), 0, 0, 160, height);//боковая левая панелька
            //forest
            g.DrawImage(Image.FromFile("tree.png"), width - 130, 200, 200, 400);
            g.DrawImage(Image.FromFile("tree.png"), width-100,    0,  200, 400);
            g.DrawImage(Image.FromFile("tree.png"), width - 100, 300, 200, 400);

            /*
            //check layout


            SolidBrush brushGreen = new SolidBrush(Color.Green);
            SolidBrush brushFrame = new SolidBrush(Color.FromArgb(139, 134, 78));


            //g.FillRectangle(new SolidBrush(Color.FromArgb(205, 179, 139)), new Rectangle(x0, y0, width, height));
            
           
            int placeHomeAnimalNumberInWidth = (width - 180) / (homeAnimalWidth);
            int placeHomeAnimalNumberInHeight = (height) / (homeAnimalHeight + wildAnimalHeight);

            //23*7

            int currX = 180;
            int currY = 0 + wildAnimalHeight;

            for (int i = 0; i < placeHomeAnimalNumberInHeight; i++)
            {
                
                    for (int j = 0; j < placeHomeAnimalNumberInWidth-2; j++)
                    {
                        if (j != 10)
                        {
                            g.FillRectangle(brushFrame, currX, currY, homeAnimalWidth, homeAnimalHeight);
                            g.FillRectangle(brushGreen, currX + 3, currY + 3, homeAnimalWidth - 6, homeAnimalHeight - 6);
                        }
                        currX += homeAnimalWidth;
                    }
                

                currY += wildAnimalHeight + homeAnimalHeight;
                currX = 180;

            }*/
        }

        public static void MakeLayout(int width, int height)
        {
           
            //23столбца*7строк
            int placeHomeAnimalNumberInWidth = (width - 180) / (homeAnimalWidth);
            int placeHomeAnimalNumberInHeight = (height) / (homeAnimalHeight + wildAnimalHeight);

            int currX = 180;
            int currY = 0 + wildAnimalHeight;

            for (int i = 0; i < placeHomeAnimalNumberInHeight; i++)
            {

                for (int j = 0; j < placeHomeAnimalNumberInWidth-2; j++)
                {
                    if (j != 10) layoyt[i, j] = new Point(currX, currY);
                    currX += homeAnimalWidth;
                }

                currY += wildAnimalHeight + homeAnimalHeight;
                currX = 180;

            }

            homeAnimalCoordinates = new List<Point>{
            new Point (layoyt[0,0].X, layoyt[0,0].Y), //hen
            new Point (layoyt[0,1].X, layoyt[0,1].Y), //hen
            new Point (layoyt[0,12].X, layoyt[0,12].Y), //cock
            new Point (layoyt[0,13].X, layoyt[0,13].Y), //cock
            new Point (layoyt[4,0].X, layoyt[4,0].Y), //pig
            new Point (layoyt[4,12].X, layoyt[4,12].Y), //duck
            new Point (layoyt[3,0].X, layoyt[3,0].Y) //rabit
        };

        }


    }
}
