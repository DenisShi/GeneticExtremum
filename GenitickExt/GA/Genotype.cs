using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA
{
    public class Genotype
    {
        public double[] Chromosome;
        public double Fitness;

        public override string ToString()
        {
            string outstr = "(";
            foreach (double ch in Chromosome)
                outstr += ch + ", ";
            outstr = outstr.Remove(outstr.Length - 2);
            outstr += ")";
            return outstr;
        }
    }
}
