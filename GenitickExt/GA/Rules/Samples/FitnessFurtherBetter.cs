using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA.Rules.Samples
{
    class FitnessFurtherBetter : FitnessRule
    {
        public override Population GetFitness(Population population)
        {
            switch (population.Problem.ExtrDirection)
            {
                case Problems.ExtremumDirection.Maximum:
                {
                        foreach (Genotype gen in population.Genotypes)
                            gen.Fitness = population.Problem.Function(gen.Chromosome);
                        break;
                }
                case Problems.ExtremumDirection.Minimum:
                {
                        foreach (Genotype gen in population.Genotypes)
                            gen.Fitness = population.Problem.Function(gen.Chromosome) * -1;
                        break;
                }
            }
            return population;
        }
    }
}
