using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static List<WildAnimal> comingWildAnimals = new List<WildAnimal>();
        public static List<HomeAnimal> homeAnimals = new List<HomeAnimal> {
            new HomeAnimal(HomeAnimal.Names.hen),
            new HomeAnimal(HomeAnimal.Names.hen),
            new HomeAnimal(HomeAnimal.Names.cock),
            new HomeAnimal(HomeAnimal.Names.cock),
            new HomeAnimal(HomeAnimal.Names.pig),
            new HomeAnimal(HomeAnimal.Names.duck)
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

        public static HomeAnimal.Names SetFood()
        {
            // если калори==0 или съел животного т е нет жертвы!!
            //caloriesEaten=1;
            return HomeAnimal.Names.rabit;
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
