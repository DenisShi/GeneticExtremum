using System;
using System.Collections.Generic;
using System.Text;
using GeniticExt.GA;

namespace GeniticExt.GA.Rules
{
    public abstract class FitnessRule
    {
        public abstract double GetFitness(Population population);
    }
}
