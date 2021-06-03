using System;
using System.Collections.Generic;
using System.Text;


namespace GenitickExt.Problems
{
    public abstract class Problem
    {
        public delegate double FunctionDelegate(double[] args);
        public FunctionDelegate Function;
        public SearchArea SearchArea;
    }

}
