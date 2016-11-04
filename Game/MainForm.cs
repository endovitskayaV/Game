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
           



            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tickCount++;

            //set homeAnimal to wildAnomal
            GameValues.SetFoodTo(GameValues.wildAnimals);


            //-----------------------------------generate wild animals----------------------------------------------------//
            GameValues.comingWildAnimals = new List<WildAnimal>();
            WildAnimal.Names[] wildAnimals = new WildAnimal.Names[] { WildAnimal.Names.bear, WildAnimal.Names.boar, WildAnimal.Names.fox, WildAnimal.Names.wolf };
            switch (tickCount)
            {
                case 1:
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;
                case 2:
                case 3:
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;
                case 4:
                case 5:
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;

                default:
                    for (int i = 0; i < tickCount; i++)
                        GameValues.comingWildAnimals.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;
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
                int intervalNumber = this.Width / GameValues.comingWildAnimals.Count;
                int y0 = 0;
                for (int j = 1; j <= 4; j++)
                {
                    for (int i = 0; i < GameValues.comingWildAnimals.Count; i++)
                        Painter.DrawComingWildAnimal(g, GameValues.comingWildAnimals[i], this.Width, i, y0 + i * intervalNumber);
                }
            }

            //wildAnimalsInGame.AddRange(GameValues.wildAnimals);


            timer.Stop();
           
           //raise money because homeAnimal is an adult
            for (int i = 0; i < GameValues.homeAnimals.Count; i++)
            {
                if (GameValues.homeAnimals[i].LifeStage == HomeAnimal.LifeStages.adult)
                {
                    GameValues.Money += GameValues.homeAnimals[i].Price;
                    GameValues.homeAnimals.Remove(GameValues.homeAnimals[i]);

                   // перерисовать только homeAnimals
                 this.Refresh();// exit from method?!!!!!!??????????? 
                }
            }
            
            

           




          

            //rise eaten calories
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
            {
                if (GameValues.wildAnimals[i].caloriesEaten >= 1)
                    GameValues.wildAnimals[i].caloriesEaten += (GameValues.wildAnimals[i].CurrentEatingHomeAnimal.EnergyValue/2)-1;
            }

            //killed?- доделать про мертвых непонятки наверняка 
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
            {
                if (GameValues.wildAnimals[i].caloriesEaten == GameValues.wildAnimals[i].EnergyCanEat)
                    GameValues.wildAnimals[i].Eat(GameValues.wildAnimals[i].CurrentEatingHomeAnimal);
                this.Refresh(); //exit?
            }


            //LifeStage++
            if (tickCount != 1)
                for (int i = 0; i < GameValues.homeAnimals.Count; i++) GameValues.homeAnimals[i].LifeStage++;

          

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

            Painter.MakeLayout(this.Width, this.Height);

            //grass
            Painter.DrawBackground(e.Graphics, 0,0, this.Height, this.Width);

            //money
            Painter.DrawMoney(e.Graphics, 15,35+15, 0,5);
            money_Lbl.Text = GameValues.Money.ToString();
            money_Lbl.BackColor = Color.FromArgb(164, 221, 99);
           

            //Shop_Btn.Image
            Shop_Btn.BackColor = Color.FromArgb(164, 221, 99);
            Shop_Btn.Image = Image.FromFile("shop2.png");
            Shop_Btn.FlatAppearance.MouseDownBackColor= Color.FromArgb(164, 221, 99);
            Shop_Btn.FlatAppearance.MouseOverBackColor= Color.FromArgb(164, 221, 99);
            Shop_Btn.FlatAppearance.BorderColor= Color.FromArgb(164, 221, 99);



            //exit_Btn
            exit_Btn.Image= Image.FromFile("exit2.png");
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
                    Painter.DrawHomeAnimal(e.Graphics, GameValues.homeAnimals[i].Name, i);
            else { MessageBox.Show("Game over!"); g.Dispose(); }

                //wildAnimals
                if (GameValues.wildAnimals.Count>0)
                for (int i = 0; i < GameValues.wildAnimals.Count; i++)
                    Painter.DrawWildAnimal(e.Graphics, GameValues.wildAnimals[i].Name, i);

           // ePaintEventArg = e;

        }

        public static void TimerStart()
        {
            timer.Start();
        }

        private void rules_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
