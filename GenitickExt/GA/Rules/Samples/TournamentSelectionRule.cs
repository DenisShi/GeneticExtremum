using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA.Rules.Samples
{
    class TournamentSelectionRule : SelectionRule
    {
        public override List<Genotype> Selection(Population population)
        {
            List<Genotype> parents = new List<Genotype>();

            if (population.Genotypes[0].Fitness > population.Genotypes[population.Genotypes.Count - 1].Fitness)
                parents.Add(population.Genotypes[0]);
            else
                parents.Add(population.Genotypes[population.Genotypes.Count - 1]);

            for (int i = 0; i < population.Genotypes.Count - 1; i++)
            {
                if (population.Genotypes[i].Fitness > population.Genotypes[i + 1].Fitness)
                    parents.Add(population.Genotypes[i]);
                else
                     parents.Add(population.Genotypes[i + 1]);
            }
            return parents;
        }
    }
}
