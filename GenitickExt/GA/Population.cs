using System;
using System.Collections.Generic;
using System.Text;
using GenitickExt.Problems;
using GenitickExt.GA.Rules;

namespace GenitickExt.GA
{
    public class Population
    {
        public Problem Problem;


        public List<Genotype> Genotypes; 
        public int GenotypeSize;

        public CrossoverRule CrossoverRule;
        public MutationRule MutationRule;
        public SelectionRule SelectionRule;

        public Population(Problem problem, CrossoverRule crossoverRule, MutationRule mutationRule, SelectionRule selectionRule, int genotypesAmount, int chromosomeLenght)
        {
            Problem = problem;
            CrossoverRule = crossoverRule;
            MutationRule = mutationRule;
            SelectionRule = selectionRule;

            GenotypeGenerator genotypeGenerator = new GenotypeGenerator();
            Genotypes = genotypeGenerator.GenerateGenotypes(genotypesAmount, chromosomeLenght, problem.SearchArea.Min, problem.SearchArea.Max);

        }

    }
}
