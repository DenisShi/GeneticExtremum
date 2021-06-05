using System;
using System.Collections.Generic;
using System.Text;
using GeniticExt.GA;

namespace GeniticExt.GA.Rules
{
    public abstract class CrossoverRule
    {
        public abstract void Crossover(Population population);
    }
}
