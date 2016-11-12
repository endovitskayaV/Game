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
        private static int homeAnimalWidth = 51;
        private static int wildAnimalWidth = 51;
        private static int homeAnimalHeight = 51;
        private static int wildAnimalHeight = 51;

        private static Point[,] layoyt = new Point[7, 21];
        private static bool[,] layoytFree = new bool[7, 21];


        public static void DrawComingWildAnimal(Graphics g, int width)
        {
            for (int i = 0; i < GameValues.comingWildAnimals.Count; i++)
            {
                if (GameValues.comingWildAnimals[i].Destination.X != 0)
                {
                    string fileName = GameValues.comingWildAnimals[i].Name.ToString() + "TracesY.png";

                    int traceWidth = 30;
                    int traceHeight = 30;


                    if (GameValues.comingWildAnimals[i].PositionY + wildAnimalHeight < GameValues.comingWildAnimals[i].Destination.Y)
                    {
                        GameValues.comingWildAnimals[i].PositionY += GameValues.comingWildAnimals[i].Speed;
                        g.DrawImage(Image.FromFile(fileName), GameValues.comingWildAnimals[i].PositionX, GameValues.comingWildAnimals[i].PositionY, traceWidth, traceHeight);
                        g.DrawImage(Image.FromFile(fileName), GameValues.comingWildAnimals[i].PositionX - 5 - traceWidth, GameValues.comingWildAnimals[i].PositionY, traceWidth, traceHeight);

                    }



                    else if (GameValues.comingWildAnimals[i].PositionY + wildAnimalHeight >= GameValues.comingWildAnimals[i].Destination.Y)

                    {
                        fileName = GameValues.comingWildAnimals[i].Name.ToString() + "TracesX.png";
                        GameValues.comingWildAnimals[i].PositionY = GameValues.comingWildAnimals[i].CurrentEatingHomeAnimal.Position.Y;

                        if (GameValues.comingWildAnimals[i].PositionX - wildAnimalWidth > GameValues.comingWildAnimals[i].Destination.X)
                        {
                            GameValues.comingWildAnimals[i].PositionX -= GameValues.comingWildAnimals[i].Speed;
                            g.DrawImage(Image.FromFile(fileName), GameValues.comingWildAnimals[i].PositionX, GameValues.comingWildAnimals[i].PositionY - 5 - traceHeight, traceWidth, traceHeight);
                            g.DrawImage(Image.FromFile(fileName), GameValues.comingWildAnimals[i].PositionX, GameValues.comingWildAnimals[i].PositionY, traceWidth, traceHeight);

                        }

                        else if (GameValues.comingWildAnimals[i].PositionX - wildAnimalWidth <= GameValues.comingWildAnimals[i].Destination.X)

                        {
                            GameValues.comingWildAnimals[i].PositionX = GameValues.comingWildAnimals[i].CurrentEatingHomeAnimal.Position.X;
                            GameValues.comingWildAnimals[i].PositionY -= wildAnimalHeight;
                            fileName = GameValues.comingWildAnimals[i].Name.ToString() + ".png";
                            g.DrawImage(Image.FromFile(fileName), GameValues.comingWildAnimals[i].PositionX, GameValues.comingWildAnimals[i].PositionY,
                            wildAnimalWidth, wildAnimalHeight);
                            GameValues.comingWildAnimals[i].Coming = false;
                            DrawHungerIndicator(g, GameValues.comingWildAnimals[i]);

                        }


                    }
                }
            }

        }

        public static void DrawWildAnimal(Graphics g)
        {
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
            {
                if (GameValues.wildAnimals[i].CurrentEatingHomeAnimal != null)
                {
                    string fileName = GameValues.wildAnimals[i].Name.ToString() + ".png";
                    g.DrawImage(Image.FromFile(fileName), GameValues.wildAnimals[i].PositionX, GameValues.wildAnimals[i].PositionY,
                        wildAnimalWidth, wildAnimalHeight);
                    DrawHungerIndicator(g, GameValues.wildAnimals[i]);

                }
            }

        }

        public static void DrawMoney(Graphics g, int x0, int y0, int width, int deltaSize)
        {
            g.DrawImage(Image.FromFile("money.png"), new Rectangle(new Point(x0 + width, y0), new Size(9 * deltaSize, 9 * deltaSize)));
        }

        public static void DrawHomeAnimal(Graphics g, HomeAnimal homeAnimal)
        {

            string fileName = homeAnimal.Name.ToString() + ".png";
            g.DrawImage(Image.FromFile(fileName), homeAnimal.Position.X, homeAnimal.Position.Y, homeAnimalWidth, homeAnimalHeight);
            DrawAgeIndicator(g, homeAnimal);
            DrawHpIndicator(g, homeAnimal);
        }

        public static void DrawMainFormBackground(Graphics g, int x0, int y0, int height, int width)
        {
            g.DrawImage(Image.FromFile("back3.png"), new Rectangle(0, 0, width, height));
            g.DrawImage(Image.FromFile("panel2.png"), new Rectangle(0, 0, 80, height));

            //forest
            g.DrawImage(Image.FromFile("tree.png"), width - 130, 200, 200, 400);
            g.DrawImage(Image.FromFile("tree.png"), width - 100, 0, 200, 400);
            g.DrawImage(Image.FromFile("tree.png"), width - 100, 300, 200, 400);

        }

        public static void DrawShopFormBackground(Graphics g, int height, int width)
        {
            g.DrawImage(Image.FromFile("roof.png"),0,0);
            g.DrawImage(Image.FromFile("bottom.png"), 0, height-181);

        }


        public static void MakeLayout(Graphics g)
        {
            int width = 1362;
            int height = 741;
            //21столбца*7строк
            int placeHomeAnimalNumberInWidth = (width - 180) / (homeAnimalWidth);
            int placeHomeAnimalNumberInHeight = (height) / (homeAnimalHeight + wildAnimalHeight);

            int currX = 180;
            int currY = 0 + wildAnimalHeight;

            //SolidBrush brushGreen = new SolidBrush(Color.Green);
            // SolidBrush brushFrame = new SolidBrush(Color.FromArgb(139, 134, 78));

            for (int i = 0; i < placeHomeAnimalNumberInHeight; i++)
            {

                for (int j = 0; j < placeHomeAnimalNumberInWidth - 2; j++)
                {
                    if (j % 2 != 0)
                    {
                        layoyt[i, j] = new Point(currX, currY);
                        layoytFree[i, j] = true;
                        //g.FillRectangle(brushFrame, currX, currY, homeAnimalWidth, homeAnimalHeight);
                        // g.FillRectangle(brushGreen, currX + 3, currY + 3, homeAnimalWidth - 6, homeAnimalHeight - 6);
                    }
                    currX += homeAnimalWidth;
                }

                currY += wildAnimalHeight + homeAnimalHeight;
                currX = 180;

            }

        }

        public static Point SetHomeAnimalsCoordinates(HomeAnimal.Names name)
        {
            Point returnPoint = new Point();
            bool gotPoint = false;
            switch (name)
            {
                case HomeAnimal.Names.hen:
                    for (int i = 0; i <= 2; i++)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            if (layoytFree[i, j])
                            {
                                gotPoint = true;
                                layoytFree[i, j] = false;
                                returnPoint = layoyt[i, j];
                                break;

                            }

                        }
                        if (gotPoint) break;
                    }


                    break;

                case HomeAnimal.Names.cock:
                    for (int i = 0; i <= 2; i++)
                    {
                        for (int j = 11; j <= 20; j++)
                        {
                            if (layoytFree[i, j])
                            {
                                gotPoint = true;
                                layoytFree[i, j] = false;

                                returnPoint = layoyt[i, j];
                                break;

                            }

                        }
                        if (gotPoint) break;
                    }

                    break;

                case HomeAnimal.Names.pig:
                    for (int i = 4; i <= 6; i++)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            if (layoytFree[i, j])
                            {
                                layoytFree[i, j] = false;
                                gotPoint = true;
                                returnPoint = layoyt[i, j];
                                break;
                            }

                        }
                        if (gotPoint) break;
                    }

                    break;

                case HomeAnimal.Names.duck:
                    for (int i = 4; i <= 6; i++)
                    {
                        for (int j = 11; j <= 20; j++)
                        {
                            if (layoytFree[i, j])
                            {
                                layoytFree[i, j] = false;
                                gotPoint = true;
                                returnPoint = layoyt[i, j];
                                break;

                            }

                        }
                        if (gotPoint) break;
                    }

                    break;

                case HomeAnimal.Names.rabit:
                    for (int j = 0; j <= 20; j++)
                    {
                        if (j != 10 && layoytFree[3, j])
                        {
                            layoytFree[3, j] = false;
                            gotPoint = true;
                            returnPoint = layoyt[3, j];
                            break;
                        }

                    }

                    break;



            }
            if (gotPoint) return returnPoint;
            else return new Point(0, 0);


        }

        public static void SoldHomeAnimal(Graphics g, HomeAnimal homeAnimal)
        {
            g.DrawImage(Image.FromFile("money.png"), homeAnimal.Position.X + homeAnimalWidth / 2, homeAnimal.Position.Y + homeAnimalHeight / 2, 42, 42);
            g.DrawImage(Image.FromFile("money.png"), homeAnimal.Position.X, homeAnimal.Position.Y, 42, 42);


            RemoveHomeAnimal(homeAnimal);
            RemoveWildAnimal(homeAnimal.Hunter);


        }

        public static void DrawEatenHomeAnimal(Graphics g, HomeAnimal homeAnimal)
        {
            g.DrawLine(new Pen(Color.Red, 3), homeAnimal.Position, new Point(homeAnimal.Position.X + homeAnimalWidth, homeAnimal.Position.Y + homeAnimalHeight));
            RemoveHomeAnimal(homeAnimal);

        }

        private static void RemoveHomeAnimal(HomeAnimal homeAnimal)
        {
            GameValues.homeAnimals.Remove(homeAnimal);
            bool finded = false;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (homeAnimal.Position == layoyt[i, j])
                    {
                        layoytFree[i, j] = true;
                        finded = true;
                        break;
                    }
                }
                if (finded) break;
            }

        }

        private static void RemoveWildAnimal(WildAnimal wildAnimal)
        {
            GameValues.wildAnimals.Remove(wildAnimal);
        }

        public static void DrawEngorgedWildAnimal(Graphics g, WildAnimal wildAnimal)
        {
            g.DrawImage(Image.FromFile("engorged.png"), wildAnimal.PositionX, wildAnimal.PositionY, wildAnimalWidth, wildAnimalHeight);
            RemoveWildAnimal(wildAnimal);
        }

        public static void DrawLostWildAnimal(Graphics g, WildAnimal wildAnimal)
        {
            g.DrawImage(Image.FromFile("ops.png"), wildAnimal.PositionX, wildAnimal.PositionY, wildAnimalWidth, wildAnimalHeight);

            string fileName = wildAnimal.Name.ToString() + "TracesY.png";
            g.DrawImage(Image.FromFile(fileName), wildAnimal.PositionX, wildAnimal.PositionY, 30, 30);
        }


        //probably private
        public static void DrawAgeIndicator(Graphics g, HomeAnimal homeAnimal)
        {
            if (homeAnimal != null)
            {
                int height = 12;
                if (homeAnimal.LifeStage == HomeAnimal.LifeStages.adult)
                {
                    g.DrawRectangle(new Pen(Color.Black), homeAnimal.Position.X - homeAnimalWidth, homeAnimal.Position.Y, homeAnimalWidth, height);
                    g.FillRectangle(new SolidBrush(Color.Yellow), homeAnimal.Position.X - homeAnimalWidth + 1, homeAnimal.Position.Y + 1, homeAnimalWidth - 1, height - 1);
                }
                else
                {
                    g.DrawRectangle(new Pen(Color.Black), homeAnimal.Position.X - homeAnimalWidth, homeAnimal.Position.Y, homeAnimalWidth, height);
                    g.FillRectangle(new SolidBrush(Color.Yellow), homeAnimal.Position.X - homeAnimalWidth + 1, homeAnimal.Position.Y + 1, (homeAnimalWidth - 1) * homeAnimal.GrowingLevel / 15, height - 1);
                }

                Rectangle teenRect = new Rectangle(homeAnimal.Position.X - homeAnimalWidth, homeAnimal.Position.Y, homeAnimalWidth * 2 / 3, height);
                Rectangle babyRect = new Rectangle(homeAnimal.Position.X - homeAnimalWidth, homeAnimal.Position.Y, homeAnimalWidth / 3, height);

                g.DrawRectangle(new Pen(Color.Black), teenRect);
                g.DrawRectangle(new Pen(Color.Black), babyRect);

            }
        }
        //probable private
        public static void DrawHungerIndicator(Graphics g, WildAnimal wildAnimal)
        {
            int width = (wildAnimalWidth * wildAnimal.caloriesEaten) / wildAnimal.EnergyCanEat;
            int height = 12;

            if (wildAnimal.caloriesEaten == wildAnimal.EnergyCanEat) width = wildAnimalWidth;



            g.DrawRectangle(new Pen(Color.Black), wildAnimal.PositionX - wildAnimalWidth, wildAnimal.PositionY, wildAnimalWidth, height);
            g.FillRectangle(new SolidBrush(Color.Red), wildAnimal.PositionX - wildAnimalWidth + 1, wildAnimal.PositionY + 1, width, height - 1);
        }

        public static void DrawHpIndicator(Graphics g, HomeAnimal homeAnimal)
        {

            int height = 12;
            if (homeAnimal.Hp == homeAnimal.EnergyValue)
            {
                g.DrawRectangle(new Pen(Color.Black), homeAnimal.Position.X - homeAnimalWidth, homeAnimal.Position.Y + height + 2, homeAnimalWidth, height);
                g.FillRectangle(new SolidBrush(Color.Blue), homeAnimal.Position.X - homeAnimalWidth + 1, homeAnimal.Position.Y + 1 + height + 2, homeAnimalWidth - 1, height - 1);
            }
            else if (homeAnimal.Hp <= 0) g.DrawRectangle(new Pen(Color.Black), homeAnimal.Position.X - homeAnimalWidth - 13, homeAnimal.Position.Y, homeAnimalWidth, height);
            else
            {
                g.DrawRectangle(new Pen(Color.Black), homeAnimal.Position.X - homeAnimalWidth, homeAnimal.Position.Y + height + 2, homeAnimalWidth, height);
                g.FillRectangle(new SolidBrush(Color.FromArgb(129, 164, 96)), homeAnimal.Position.X - homeAnimalWidth + 1, homeAnimal.Position.Y + 1 + height + 2, homeAnimalWidth - 1, height - 1);
                g.FillRectangle(new SolidBrush(Color.LightBlue), homeAnimal.Position.X - homeAnimalWidth + 1, homeAnimal.Position.Y + 1 + height + 2, (homeAnimalWidth - 1) * homeAnimal.Hp / homeAnimal.EnergyValue, height - 1);
            }



        }

    }
}

