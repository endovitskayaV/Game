using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class HomeAnimal 
    {
        //fields
        public enum Names { rabit, duck, pig, cock, hen };
        private Dictionary<Names, int> energyWeight = new Dictionary<Names, int>()
        {
            {Names.rabit, 28},
            {Names.duck,8},
            {Names.pig, 14},
            {Names.cock, 4},
            {Names.hen, 2}
        };

        private Dictionary<Names, int> price = new Dictionary<Names, int>()
        {
            {Names.rabit, 28},
            {Names.duck,8},
            {Names.pig, 14},
            {Names.cock, 4},
            {Names.hen, 2}
        };
        public enum LifeStages {baby, teen, adult};
        private LifeStages lifeStage;
        private Names name;
        private bool alive;
        private int energyValue;
       

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
        public int EnergyValue { get; set; }
        public int Price
        {
            get
            {
                return price[name];
            }
        }
        

        //конструктор
        public HomeAnimal(Names name)
        {
            this.name = name;
            energyValue = energyWeight[name];
            lifeStage =LifeStages.baby;
            alive = true;
        }

        //methods

    //кому увеличить возраст при покупке корма 


    }
}
