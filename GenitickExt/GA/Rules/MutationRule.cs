using System;
using System.Collections.Generic;
using System.Text;
using GenitickExt.GA;

namespace GenitickExt.GA.Rules
{
    public abstract class MutationRule
    {
        public abstract Population Mutation(Population population);
    }
}