using System;
using System.Collections.Generic;
using System.Text;
using GeniticExt.Problems;
using GeniticExt.GA.Rules;

namespace GeniticExt.GA
{
    public class Population
    {
        public Problem Problem;


        public List<Genotype> Genotypes; 
        public int GenotypeSize;

        public FitnessRule FitnessRule;
        public SelectionRule SelectionRule;
        public CrossoverRule CrossoverRule;
        public MutationRule MutationRule;

        public Population(Problem problem, CrossoverRule crossoverRule, MutationRule mutationRule, SelectionRule selectionRule, int genotypesAmount, int chromosomeLenght)
        {
            Problem = problem;
            CrossoverRule = crossoverRule;
            MutationRule = mutationRule;
            SelectionRule = selectionRule;

            GenotypeGenerator genotypeGenerator = new GenotypeGenerator();
            Genotypes = genotypeGenerator.GenerateGenotypes(genotypesAmount, chromosomeLenght, problem.SearchArea.Min, problem.SearchArea.Max);

        }

        public void NextGeneration()
        {
            FitnessRule.GetFitness(this);
            SelectionRule.Selection(this);
            CrossoverRule.Crossover(this);
            MutationRule.Mutation(this);
        }
    }
}
