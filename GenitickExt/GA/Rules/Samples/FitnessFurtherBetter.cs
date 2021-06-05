using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA.Rules.Samples
{
    class FitnessFurtherBetter : FitnessRule
    {
        public override void GetFitness(Population population)
        {
            switch (population.Problem.ExtrDirection)
            {
                case Problems.ExtremumDirection.Maximum:
                {
                        foreach (Chromosome gen in population.Genotypes)
                            gen.Fitness = population.Problem.Function(gen.Genes);
                        break;
                }
                case Problems.ExtremumDirection.Minimum:
                {
                        foreach (Chromosome gen in population.Genotypes)
                            gen.Fitness = population.Problem.Function(gen.Genes) * -1;
                        break;
                }
            }

        }
    }
}
