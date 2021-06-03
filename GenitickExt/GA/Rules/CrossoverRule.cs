using System;
using System.Collections.Generic;
using System.Text;
using GenitickExt.GA;

namespace GenitickExt.GA.Rules
{
    public abstract class CrossoverRule
    {
        public abstract Population Crossover(Population population);
    }
}
