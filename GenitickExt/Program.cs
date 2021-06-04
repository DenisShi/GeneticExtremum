using System;
using GeniticExt.Problems.Example;
using GeniticExt.Problems;
using System.Collections.Generic;
using GeniticExt.GA;

namespace GeniticExt
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem cp = new ConcreteProblem();
            double[] ca = new double[2] { 0, 0 };
            Console.WriteLine(cp.Function(ca));
            
            List<Genotype> Genotypes;
            GenotypeGenerator genotypeGenerator = new GenotypeGenerator();
            Genotypes = genotypeGenerator.GenerateGenotypes(100,2,5,-5);
            foreach (Genotype g in Genotypes)
                Console.WriteLine(g);

        }
    }

}
