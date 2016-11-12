using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class HomeAnimal 
    {
        //fields
        public enum Names { rabit, duck, pig, cock, hen };
        private Dictionary<Names, int> energyWeight = new Dictionary<Names, int>()
        {
            {Names.rabit, 27},
            {Names.duck,9},
            {Names.pig, 12},
            {Names.cock, 6},
            {Names.hen, 3}
        };

        private Dictionary<Names, int> price = new Dictionary<Names, int>()
        {
            {Names.rabit, 28},
            {Names.duck,8},
            {Names.pig, 14},
            {Names.cock, 4},
            {Names.hen, 2}
        };
        public enum LifeStages {none, baby, teen,  adult};
        private LifeStages lifeStage;
        private Names name;
        private bool alive;
        private int energyValue;
        private WildAnimal hunter;
        private Point position;
        private int growSpeed;
        private int growingLevel;
        private int hp;
       
       
       

        //properties
        public LifeStages LifeStage
        {
            get
            {
                return lifeStage;
            }
            set
            {
                lifeStage = value;
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
        public int EnergyValue
        {
            get
            {
                return energyValue;
            }
        }
        public int Price
        {
            get
            {
                return price[name];
            }
        }
        public WildAnimal Hunter
        {
            get
            {
                return hunter;
            }

            set
            {
                hunter = value;
            }

        }
        public Point Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
        public int GrowSpeed
        {
            get
            {
                return growSpeed;
            }
            set
            {
                growSpeed = value;
            }

        }
        public int GrowingLevel
        {
            get
            {
                return growingLevel;
            }
            set
            {
                growingLevel = value;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }



        //конструктор
        public HomeAnimal(Names name)
        {
            this.name = name;
            energyValue = energyWeight[name];
            lifeStage =LifeStages.none;
            alive = true;
            hunter = null;
            position=Painter.SetHomeAnimalsCoordinates(name);
            growSpeed = 1;
            energyValue = energyWeight[name];
            growingLevel = 0;
            hp = energyWeight[name];
        }

        //methods

        public static void Grow()
        {
            int maxGrowingLevelForOneStage = 7;

            for (int i= 0; i< GameValues.homeAnimals.Count; i++)
            {
                if (GameValues.homeAnimals[i].hunter==null || GameValues.homeAnimals[i].hunter.caloriesEaten<=1)
                {
                    GameValues.homeAnimals[i].GrowingLevel += GameValues.homeAnimals[i].growSpeed;
                    if (GameValues.homeAnimals[i].GrowingLevel % maxGrowingLevelForOneStage == 0 && GameValues.homeAnimals[i].LifeStage != HomeAnimal.LifeStages.adult)
                        GameValues.homeAnimals[i].LifeStage++;
                }
            }
        }

        //кому увеличить возраст при покупке корма ?

        public static void IncreaseLifeStage(HomeAnimal homeAnimal)
        {
            homeAnimal.LifeStage++;
        }
 


    }
}
