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
        List<WildAnimal> wildAnimalsInGame;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            tickCount = 0;


            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            timer.Stop();
           //raise money because homeAnimal is an adult
            for (int i = 0; i < GameValues.homeAnimals.Count; i++)
            {
                if (GameValues.homeAnimals[i].LifeStage == HomeAnimal.LifeStages.adult)
                {
                    GameValues.Money += GameValues.homeAnimals[i].Price;
                    GameValues.homeAnimals.Remove(GameValues.homeAnimals[i]);

                    this.Refresh();// exit from method?!!!!!!??????????? 
                }
            }

            tickCount++;

            //LifeStage++
            if(tickCount!=1)
            for (int i = 0; i < GameValues.homeAnimals.Count; i++) GameValues.homeAnimals[i].LifeStage++;

            //set homeAnimal to wildAnomal
            if (GameValues.wildAnimals.Count > 0) GameValues.SetFood();

            //rise eaten calories
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
            {
                if (GameValues.wildAnimals[i].caloriesEaten >= 1)
                    GameValues.wildAnimals[i].caloriesEaten += (GameValues.wildAnimals[i].CurrentEating.EnergyValue/2)-1;
            }

            //killed?- доделать про мертвых непонятки наверняка 
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
            {
                if (GameValues.wildAnimals[i].caloriesEaten == GameValues.wildAnimals[i].EnergyCanEat)
                    GameValues.wildAnimals[i].Eat(GameValues.wildAnimals[i].CurrentEating);
                this.Refresh(); //exit?
            }

            //-----------------------------------generate wild animals----------------------------------------------------//
            wildAnimalsInGame = new List<WildAnimal>();
            WildAnimal.Names[] wildAnimals = new WildAnimal.Names[] { WildAnimal.Names.bear, WildAnimal.Names.boar, WildAnimal.Names.fox, WildAnimal.Names.wolf };
            switch (tickCount)
            {
               // case 1: wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length+1)]));
               //      break;
                case 2:
                case 3:
                    wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;
                case 4:
                case 5:
                    wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;

                default:
                    for (int i = 0; i < tickCount; i++)
                        wildAnimalsInGame.Add(new WildAnimal(wildAnimals[random.Next(0, wildAnimals.Length)]));
                    break;
            }

            wildAnimalsInGame.AddRange(GameValues.wildAnimals);

           
           //---------------------------------------------------------------------------------------------------------------------------//
           


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

            Painter.MakeLayout();

            //grass
            Painter.Background(e.Graphics, 0,0, this.Height, this.Width);

            //money
            Painter.Money(e.Graphics, moneyShow_Lbl.Location.X, moneyShow_Lbl.Location.Y-3, moneyShow_Lbl.Width,1);
            moneyShow_Lbl.Text = GameValues.Money.ToString();

            // homeAnimals
            if (GameValues.homeAnimals.Count > 0)
                for (int i = 0; i < GameValues.homeAnimals.Count; i++)
                    Painter.HomeAnimal(e.Graphics, GameValues.homeAnimals[i].Name, i);
            else MessageBox.Show("Game over!");

            //wildAnimals
            if (GameValues.wildAnimals.Count>0)
                for (int i = 0; i < GameValues.wildAnimals.Count; i++)
                    Painter.WildAnimal(e.Graphics, GameValues.wildAnimals[i].Name, i);

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
