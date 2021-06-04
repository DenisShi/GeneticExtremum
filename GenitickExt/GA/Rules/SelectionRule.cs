using System;
using System.Collections.Generic;
using System.Text;
using GeniticExt;
using GeniticExt.GA;

namespace GeniticExt.GA.Rules
{
    public abstract class SelectionRule
    {
        public abstract List<Genotype> Selection(Population population);
    }
}
