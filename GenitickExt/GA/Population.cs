using System;
using System.Collections.Generic;
using System.Text;
using GeniticExt.Problems;
using GeniticExt.GA.Rules;
using System.Linq;

namespace GeniticExt.GA
{
    public class Population
    {
        public Problem Problem;


        public List<Genotype> Genotypes;
        public Genotype BestGenotype;
        public List<Genotype> Parents;
        public int ChromosomeLenght;

        public FitnessRule FitnessRule;
        public SelectionRule SelectionRule;
        public CrossoverRule CrossoverRule;
        public MutationRule MutationRule;
        public double MutationRate;

        GenotypeGenerator GenotypeGenerator;

        public Random Rnd = new Random();

        public int MaxNoProgressIterations;
        private int _noProgressIterations;
        private int _iterationsTotal;

        public Population(Problem problem, FitnessRule fitnessRule, CrossoverRule crossoverRule, MutationRule mutationRule, 
            SelectionRule selectionRule, int genotypesAmount, int chromosomeLenght, double mutationRate, int maxNoProgressIterations)
        {
            FitnessRule = fitnessRule;
            Problem = problem;
            CrossoverRule = crossoverRule;
            MutationRule = mutationRule;
            SelectionRule = selectionRule;
            ChromosomeLenght = chromosomeLenght;
            MutationRate = mutationRate;
            MaxNoProgressIterations = maxNoProgressIterations;

            GenotypeGenerator = new GenotypeGenerator();
            Genotypes = GenotypeGenerator.GenerateGenotypes(genotypesAmount, chromosomeLenght, problem.SearchArea.Min, problem.SearchArea.Max);

            FitnessRule.GetFitness(this);
            BestGenotype = GetBestGenotypeInGeneration();

        }
        public Population() { }

        public void Go()
        {
            while (_noProgressIterations < MaxNoProgressIterations)
            {
                NextGeneration();
                _iterationsTotal++;
            }
        }

        public void NextGeneration()
        {
            SelectionRule.Selection(this);
            CrossoverRule.Crossover(this);
            MutationRule.Mutation(this);
            FitnessRule.GetFitness(this);

            Genotype bestGen = GetBestGenotypeInGeneration();
            if(BestGenotype.Fitness < bestGen.Fitness)
            {
                BestGenotype = bestGen.Copy();
                _noProgressIterations = 0;
            }

            else
            {
                _noProgressIterations++;
            }
        }

        public Genotype GetBestGenotypeInGeneration()
        {
            double min = Genotypes.Max(gen => gen.Fitness);
            return Genotypes.FirstOrDefault(gen => gen.Fitness == min);
        }

        public override string ToString()
        {
            return $"Лучшее решение: {BestGenotype}\n" +
                $"Всего итераций {_iterationsTotal}";
        }
    }
}
