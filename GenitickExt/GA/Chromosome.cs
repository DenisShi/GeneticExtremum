using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA
{
    public class Chromosome
    {
        public double[] Genes;
        public double Fitness;

        public override string ToString()
        {
            string outstr = "(";
            foreach (double ch in Genes)
                outstr += ch + ", ";
            outstr = outstr.Remove(outstr.Length - 2);
            outstr += ")";
            return outstr;
        }

        public Chromosome Copy()
        {
            return new Chromosome()
            {
                Fitness = this.Fitness,
                Genes = (double[])this.Genes.Clone()
            };
        }
    }
}
