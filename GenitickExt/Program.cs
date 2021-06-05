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
            Population population = new Population(new ConcreteProblem(), new FitnessFurtherBetter(), new FiftyCrossoverRule(), new OneGenInMutationRateMutationRule(), new TournamentSelectionRule(), 500, 2, 0.7, 150);
            population.Go();
            Console.WriteLine(population);
        }
    }
}
