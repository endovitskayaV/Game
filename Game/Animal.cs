﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface Animal
    {
       bool Alive { get; set; }
       bool Hungry { get; set; }
       string Name { get; set; }
       
    }


}