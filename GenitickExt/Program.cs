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
            Problem cp = new ConcreteProblem();
            Population population = new Population(cp, new FitnessFurtherBetter(), new FiftyCrossoverRule(), new OneGenInMutationRateMutationRule(), new TournamentSelectionRule(), 500, 2, 0.7, 100);
            population.Go();
            Console.WriteLine(population);
        }

    }

}
