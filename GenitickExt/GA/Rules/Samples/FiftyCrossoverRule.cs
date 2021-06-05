using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA.Rules.Samples
{
    class FiftyCrossoverRule : CrossoverRule
    {
        public override void Crossover(Population population)
        {
            Random rnd = population.Rnd;

            List<Genotype> childs = new List<Genotype>();
            for (int i = 0; i < population.Parents.Count; i++)
            {
                Genotype[] pair = new Genotype[2];
                Genotype child = new Genotype();
                child.Chromosome = new double[population.ChromosomeLenght];
                pair[0] = population.Parents[rnd.Next(population.Parents.Count)];
                pair[1] = population.Parents[rnd.Next(population.Parents.Count)];
                for (int j = 0; j < population.ChromosomeLenght; j++)
                {
                    child.Chromosome[j] = pair[rnd.Next(2)].Chromosome[j];
                }
                childs.Add(child);
            }
            population.Genotypes = childs;
        }
    }
}
