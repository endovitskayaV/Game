using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        private static Timer timer;
        private Random random;
        private int tickCount;
        private Graphics g;


        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            tickCount = 0;
            g = CreateGraphics();
            Painter.MakeLayout(g);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; //1c
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tickCount++;





            //wildAnimalsList.Add(comingWildAnimalsList)
            for (int i = 0; i < GameValues.comingWildAnimals.Count; i++)
            {
                if (!GameValues.comingWildAnimals[i].Coming)
                {
                    GameValues.wildAnimals.Add(GameValues.comingWildAnimals[i]);
                    GameValues.comingWildAnimals.Remove(GameValues.comingWildAnimals[i]);

                }

            }

            //set homeAnimal to wildAnomal 
            GameValues.SetFoodTo(GameValues.wildAnimals);
            Painter.DrawWildAnimal(g);


            //-----------------------------------generate wild animals----------------------------------------------------//
            //GameValues.comingWildAnimals = new List<WildAnimal>();
            WildAnimal.Names[] wildAnimals = new WildAnimal.Names[] { WildAnimal.Names.bear, WildAnimal.Names.boar, WildAnimal.Names.fox, WildAnimal.Names.wolf };

            switch (tickCount)
            {
                case 3:
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;

                case 16:
                case 32:
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;
                case 48:
                case 64:
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;


            }
            if (tickCount > 64 + 10)
            {
                for (int i = 0; i < tickCount / 10; i++)
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
            }

            //---------------------------------------------------------------------------------------------------------------------------//


            //set homeAnimal to comingWildAnimal

            // delete comingWildAnimals who did not get homeAnimal to eat
            //from GameValues.comingWildAnimals list

            GameValues.SetFoodTo(GameValues.comingWildAnimals);

            for (int i = 0; i < GameValues.comingWildAnimals.Count; i++)
            {
                if (GameValues.comingWildAnimals[i].CurrentEatingHomeAnimal == null)
                {
                    GameValues.comingWildAnimals.RemoveRange(i, GameValues.comingWildAnimals.Count - i);
                    break;
                }
            }

            //Paint comingWildAnimals
            if (GameValues.comingWildAnimals.Count != 0)
            {
                for (int i = 0; i < GameValues.comingWildAnimals.Count; i++)
                {
                    if (GameValues.comingWildAnimals[i].CurrentEatingHomeAnimal == null)
                    {
                        GameValues.comingWildAnimals[i].Destination = new Point(0, 0);
                        GameValues.comingWildAnimals[i].PositionX = this.Width - 100;
                        GameValues.comingWildAnimals[i].PositionY = 0;
                        Painter.DrawLostWildAnimal(g, GameValues.comingWildAnimals[i]);

                    }
                }
                Painter.DrawComingWildAnimal(g, this.Width);
            }



            //raise money because homeAnimal is an adult


            for (int i = 0; i < GameValues.homeAnimals.Count; i++)
            {
                if (GameValues.homeAnimals[i].LifeStage == HomeAnimal.LifeStages.adult && (GameValues.homeAnimals[i].Hunter == null || GameValues.homeAnimals[i].Hunter.caloriesEaten <= 1))
                {
                    GameValues.Money += GameValues.homeAnimals[i].Price;
                    money_Lbl.Text = GameValues.Money.ToString();

                    if (GameValues.homeAnimals[i].Hunter != null)
                    {
                        GameValues.homeAnimals[i].Hunter.CurrentEatingHomeAnimal = null;
                        Painter.DrawLostWildAnimal(g, GameValues.homeAnimals[i].Hunter);
                    }
                    Painter.SoldHomeAnimal(g, GameValues.homeAnimals[i]); //+ remove from layout +from GameValues



                }


            }


            //rise eaten calories
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
            {
                if (GameValues.wildAnimals[i].caloriesEaten >= 1 && GameValues.wildAnimals[i].CurrentEatingHomeAnimal != null)
                {
                    GameValues.wildAnimals[i].caloriesEaten += GameValues.wildAnimals[i].CurrentEatingHomeAnimal.EnergyValue / 3;
                    GameValues.wildAnimals[i].CurrentEatingHomeAnimal.Hp -= GameValues.wildAnimals[i].CurrentEatingHomeAnimal.EnergyValue / 3;
                    Painter.DrawHungerIndicator(g, GameValues.wildAnimals[i]);
                    Painter.DrawHpIndicator(g, GameValues.wildAnimals[i].CurrentEatingHomeAnimal);

                    //killed?
                    if (GameValues.wildAnimals[i].CurrentEatingHomeAnimal.Hp <= 0)
                    {
                        GameValues.wildAnimals[i].Ate(GameValues.wildAnimals[i].CurrentEatingHomeAnimal);
                        Painter.DrawEatenHomeAnimal(g, GameValues.wildAnimals[i].CurrentEatingHomeAnimal);
                        GameValues.wildAnimals[i].CurrentEatingHomeAnimal = null;
                        GameValues.wildAnimals[i].Coming = true;
                        GameValues.comingWildAnimals.Add(GameValues.wildAnimals[i]);
                    }
                }
            }

            //Engorged
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
            {
                if (GameValues.wildAnimals[i].caloriesEaten >= GameValues.wildAnimals[i].EnergyCanEat)
                {
                    Painter.DrawEngorgedWildAnimal(g, GameValues.wildAnimals[i]);
                }
            }






            //LifeStage++
            HomeAnimal.Grow();


            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Refresh();
        }

        private void Shop_Btn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ShopForm form = new ShopForm();
            form.ShowDialog();
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            this.Text = " " + e.X + " " + e.Y;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

            //if (tickCount == 0)
            // {

            //grass
            Painter.DrawMainFormBackground(e.Graphics, 0, 0, this.Height, this.Width);

            //money
            Painter.DrawMoney(e.Graphics, 15, 35 + 15, 0, 5);
            money_Lbl.Text = GameValues.Money.ToString();
            // money_Lbl.Text = "0";
            money_Lbl.BackColor = Color.FromArgb(164, 221, 99);


            //Shop_Btn.Image
            Shop_Btn.BackColor = Color.FromArgb(164, 221, 99);
            Shop_Btn.Image = Image.FromFile("shop2.png");
            Shop_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(164, 221, 99);
            Shop_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 221, 99);
            Shop_Btn.FlatAppearance.BorderColor = Color.FromArgb(164, 221, 99);



            //exit_Btn
            exit_Btn.Image = Image.FromFile("exit2.png");
            exit_Btn.BackColor = Color.FromArgb(164, 221, 99);
            exit_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(164, 221, 99);
            exit_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 221, 99);
            exit_Btn.FlatAppearance.BorderColor = Color.FromArgb(164, 221, 99);

            //rules_Btn

            rules_Btn.Image = Image.FromFile("rules2.png");
            rules_Btn.BackColor = Color.FromArgb(164, 221, 99);
            rules_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(164, 221, 99);
            rules_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 221, 99);
            rules_Btn.FlatAppearance.BorderColor = Color.FromArgb(164, 221, 99);




            // homeAnimals

            if (GameValues.homeAnimals.Count > 0)
                for (int i = 0; i < GameValues.homeAnimals.Count; i++)
                    Painter.DrawHomeAnimal(e.Graphics, GameValues.homeAnimals[i]);


            else if (GameValues.Money == 0) { MessageBox.Show("Game over!"); g.Dispose(); }

            //wildAnimals
            if (GameValues.wildAnimals.Count > 0)
                for (int i = 0; i < GameValues.wildAnimals.Count; i++)
                {
                    Painter.DrawWildAnimal(e.Graphics);
                    Painter.DrawHungerIndicator(e.Graphics, GameValues.wildAnimals[i]);
                }

            // ePaintEventArg = e;

            // }
        }

        public static void TimerStart()
        {
            timer.Start();
        }

        private void rules_Btn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            RulesForm form = new RulesForm();
            form.ShowDialog();
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void rules_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            rules_Btn.Image = Image.FromFile("rules3.png");
        }

        private void Shop_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            Shop_Btn.Image = Image.FromFile("shop3.png");
        }

        private void rules_Btn_MouseLeave(object sender, EventArgs e)
        {
            rules_Btn.Image = Image.FromFile("rules2.png");
        }

        private void exit_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            exit_Btn.Image = Image.FromFile("exit3.png");
        }

        private void exit_Btn_MouseLeave(object sender, EventArgs e)
        {
            exit_Btn.Image = Image.FromFile("exit2.png");
        }

        
    }
}
