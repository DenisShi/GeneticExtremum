using System;
using GeniticExt.Problems.Example;
using GeniticExt.Problems;
using System.Collections.Generic;
using GeniticExt.GA;
using GeniticExt.GA.Rules.Samples;

namespace GeniticExt
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests();

        }

        private static void Tests()
        {
            Problem cp = new ConcreteProblem();
            double[] ca = new double[2] { 0, 0 };
            Console.WriteLine(cp.Function(ca));

            List<Genotype> Genotypes;
            GenotypeGenerator genotypeGenerator = new GenotypeGenerator();
            Genotypes = genotypeGenerator.GenerateGenotypes(10, 2, 5, -5);


            Population population = new Population();
            population.Problem = cp;
            population.Genotypes = Genotypes;
            population.FitnessRule = new FitnessFurtherBetter(); ;
            population.SelectionRule = new TournamentSelectionRule();
            population.CrossoverRule = new FiftyCrossoverRule();
            population.ChromosomeLenght = 2;
            
            population.FitnessRule.GetFitness(population);
            population.SelectionRule.Selection(population);

            Random rnd = new Random();

            population.CrossoverRule.Crossover(population);
            
        }
    }

}
