using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA
{
    public class GenotypeGenerator
    {
        public virtual List<Chromosome> GenerateGenotypes(int genotypesAmount, int chromosomeLenght, double min, double max)
        {
            Random random = new Random();

            List<Chromosome> genotypes = new List<Chromosome>(genotypesAmount);
            while (genotypesAmount-- > 0)
                genotypes.Add(GenerateGenotype(chromosomeLenght, min, max, random));
            return genotypes;
        }
        public virtual Chromosome GenerateGenotype(int chromosomeLenght, double min, double max, Random random)
        {
            Chromosome gene = new Chromosome()
            {
                Genes = new double[chromosomeLenght]
            };
            for(int i = chromosomeLenght; i > 0; i--)
                gene.Genes[i - 1] = min + random.NextDouble() * (max - min);
            return gene;
        }
    }
}
