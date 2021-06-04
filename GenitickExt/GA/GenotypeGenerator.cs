using System;
using System.Collections.Generic;
using System.Text;

namespace GeniticExt.GA
{
    public class GenotypeGenerator
    {
        public virtual List<Genotype> GenerateGenotypes(int genotypesAmount, int chromosomeLenght, double min, double max)
        {
            List<Genotype> genotypes = new List<Genotype>(genotypesAmount);
            while (genotypesAmount-- > 0)
                genotypes.Add(GenerateGenotype(chromosomeLenght, max, min));
            return genotypes;
        }
        public virtual Genotype GenerateGenotype(int chromosomeLenght, double min, double max)
        {
            Random random = new Random();
            Genotype gene = new Genotype()
            {
                Chromosome = new double[chromosomeLenght]
            };
            for(int i = chromosomeLenght; i > 0; i--)
                gene.Chromosome[i - 1] = min + random.NextDouble() * (max - min);
            return gene;
        }
    }
}
