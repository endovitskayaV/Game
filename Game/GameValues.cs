using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public  class GameValues
    {
        private static int money=20;
        public List<WildAnimal> wildAnimals = new List<WildAnimal>();
        public List<HomeAnimal> homeAnimals = new List<HomeAnimal>();
        public static List<HomeAnimal> embryosBought = new List<HomeAnimal>();
        public static List<WildAnimal> trapsBought = new List<WildAnimal>();

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

    }
}
