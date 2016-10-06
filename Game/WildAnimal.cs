using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class WildAnimal : Animal
    {
        public enum Names { wolf, fox, bear, boar};
        public Dictionary<Names, int> energyCanEat = new Dictionary<Names, int>()
        {
            {Names.wolf, 12},
            {Names.fox, 5},
            {Names.bear, 20},
            {Names.boar, 26}
        };

        public bool Alive { get; set; }
        public bool Hungry { get; set; }
        public string Name { get; set; }
        public bool Caught { get; set; }
        public int MaxEaten { get; set; }

        public WildAnimal(Names name)
        {
            Name = name.ToString();
            MaxEaten = energyCanEat[name];  
        }

        public void Eat(HomeAnimal homeAnimal)
        {
            homeAnimal.Alive = false;
        }



    }
}
