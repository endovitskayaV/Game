using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class WildAnimal
    {
        //fields
        public enum Names { wolf, fox, bear, boar};
        private Dictionary<Names, int> energyCanEat = new Dictionary<Names, int>()
        {
            {Names.wolf, 12},
            {Names.fox, 5},
            {Names.bear, 20},
            {Names.boar, 26}
        };

        private bool alive;
        private int calogiesEaten;
        private Names name;
        private bool caught;
        private HomeAnimal currentEating;

        //properties
        public bool Alive
        {
            get
            {
                return alive;
            }
            set
            {
                alive = value;
            }
        }
        public int caloriesEaten
        {
            get
            {
                return calogiesEaten;
            }

            set
            {
                calogiesEaten = value;
            }
        }
        public Names Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
                
        }
        public bool Caught
        {
            get
            {
                return caught;
            }
            set
            {
                caught = value;
            }
        }
        public HomeAnimal CurrentEating
        {
            get
            {
                return currentEating;
            }

            set
            {
                currentEating = value;
            }
        }
        public int EnergyCanEat
        {
            get
            {
                return energyCanEat[name];
            }
        }
        
        //конструктор
        public WildAnimal(Names name)
        {
            this.name = name;
            alive = true;
            Caught = false;
            caloriesEaten = 0;
        }


        //methods
        public void Eat(HomeAnimal homeAnimal)
        {
            homeAnimal.Alive = false;
        }

       


    }
}
