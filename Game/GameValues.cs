using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public  class GameValues
    {
        //load from shop & mainForm
        private static int money=0;
       
        //load from shop
        public static List<HomeAnimal> embryosBought = new List<HomeAnimal>();
        public static List<WildAnimal> trapsBought = new List<WildAnimal>();

        //load from mainForm
        public static List<WildAnimal> wildAnimals = new List<WildAnimal>();
        public static List<WildAnimal> comingWildAnimals= new List<WildAnimal>();
        public static List<HomeAnimal> homeAnimals = new List<HomeAnimal> {
            new HomeAnimal(HomeAnimal.Names.hen),
            new HomeAnimal(HomeAnimal.Names.hen),
            new HomeAnimal(HomeAnimal.Names.cock),
            new HomeAnimal(HomeAnimal.Names.cock),
            new HomeAnimal(HomeAnimal.Names.pig),
            new HomeAnimal(HomeAnimal.Names.duck),
            new HomeAnimal(HomeAnimal.Names.rabit)
        };

        public static int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }

        public static void SetFoodTo(List<WildAnimal> huntersList)
        {
            if (huntersList != null)
            {

                for (int i = 0; i < huntersList.Count; i++)// по всем huntersList
                {
                    for (int j = 0; j < homeAnimals.Count; j++)// по всем домашним животным
                    {
                        if (homeAnimals[j].Hunter == null && huntersList[i].CurrentEatingHomeAnimal==null) //если домашнего животного никто не ест
                        {                                                                                  // и у дикого нет еды
                            huntersList[i].CurrentEatingHomeAnimal = homeAnimals[j];
                            homeAnimals[j].Hunter = huntersList[i];
                            huntersList[i].Destination = homeAnimals[j].Position;   
                            huntersList[i].caloriesEaten++;
                        }
                    }
                    if (huntersList[i].CurrentEatingHomeAnimal == null)// если нет свободных жертв 
                    {
                        huntersList[i].Destination = new Point(0, 0);
                        huntersList[i].CurrentEatingHomeAnimal = null; 
                    }
                }
            }
        }

        public static void AddBoughtEmbryons()
        {
            for (int i = 0; i < embryosBought.Count; i++)
            {
                homeAnimals.Add(embryosBought[i]);
            }
        }

        public static void AddBoughtTraps()
        { }



    }
}
