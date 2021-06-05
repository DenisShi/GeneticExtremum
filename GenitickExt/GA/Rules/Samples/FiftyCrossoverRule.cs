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

            List<Chromosome> childs = new List<Chromosome>();
            for (int i = 0; i < population.Parents.Count; i++)
            {
                Chromosome[] pair = new Chromosome[2];
                Chromosome child = new Chromosome();
                child.Genes = new double[population.ChromosomeLenght];
                pair[0] = population.Parents[rnd.Next(population.Parents.Count)];
                pair[1] = population.Parents[rnd.Next(population.Parents.Count)];
                for (int j = 0; j < population.ChromosomeLenght; j++)
                {
                    child.Genes[j] = pair[rnd.Next(2)].Genes[j];
                }
                childs.Add(child);
            }
            population.Genotypes = childs;
        }
    }
}
