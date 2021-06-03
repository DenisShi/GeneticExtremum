using System;
using System.Collections.Generic;
using System.Text;
using GenitickExt;
using GenitickExt.GA;

namespace GenitickExt.GA.Rules
{
    public abstract class SelectionRule
    {
        public abstract Population Selection(Population population);
    }
}
