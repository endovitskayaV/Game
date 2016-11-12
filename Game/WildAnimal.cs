using System;
using System.Collections.Generic;
using System.Drawing;
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
        private HomeAnimal currentEatingHomeAnimal;
        private int speed;
        private int positionX;
        private int positionY;
        private Point destination;
        private bool coming;

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
        public HomeAnimal CurrentEatingHomeAnimal
        {
            get
            {
                return currentEatingHomeAnimal;
            }

            set
            {
                currentEatingHomeAnimal = value;
            }
        }
        public int EnergyCanEat
        {
            get
            {
                return energyCanEat[name];
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
               speed = value;
            }
        }
        public int PositionX
        {
            get
            {
                return positionX;
            }

            set
            {
                positionX= value;
            }
        }
        public int PositionY
        {
            get
            {
                return positionY;
            }

            set
            {
                positionY = value;
            }
        }
        public Point Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }
        public bool Coming
        {
            get
            {
                return coming;
            }
            set
            {
                coming = value;
            }
        }

        //конструктор
        public WildAnimal(Names name)
        {
            this.name = name;
            alive = true;
            Caught = false;
            caloriesEaten = 0;
            currentEatingHomeAnimal = null;
            speed = 90; // пиксели в секунду
            positionX =1362-100;
            positionY = 0;
            destination = new Point(0, 0);
            caught = false;
            coming = true;
        }




        //methods
        public  void Ate(HomeAnimal homeAnimal)
        {
            homeAnimal.Alive = false;
            homeAnimal.Hp = 0;
        }

        public static void Move()
        {
            for (int i = 0; i < GameValues.wildAnimals.Count; i++)
             {
                GameValues.wildAnimals[i].positionX += GameValues.wildAnimals[i].Speed;
                GameValues.wildAnimals[i].positionY += GameValues.wildAnimals[i].Speed;

             }
        }

        // кого поймать купленной ловушкой или это в game values
        public static void Catch(WildAnimal wildAnimal)
        {
            wildAnimal.Caught = true;
            wildAnimal.Alive = false;
        }

       


    }
}
