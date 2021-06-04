using System;
using System.Collections.Generic;
using System.Text;
using GeniticExt.GA;

namespace GeniticExt.GA.Rules
{
    public abstract class FitnessRule
    {
        public abstract Population GetFitness(Population population);
    }
}
