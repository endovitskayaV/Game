using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class HomeAnimal : Animal
    {
        public enum Names { rabit, duck, pig, cock, hen };
        public Dictionary<Names, int> energyCanEat = new Dictionary<Names, int>()
        {
            {Names.rabit, 26},
            {Names.duck,7},
            {Names.pig, 13},
            {Names.cock,5},
            {Names.hen, 1}
        };

        public enum LifeStages {baby, teen, adult};

        public LifeStages LifeStage { get; set; }
        public bool Alive { get; set; }
        public bool Hungry { get; set; }
        public string Name { get; set; }
        public int energyValue { get; set; }


    }
}
