﻿using System;
using System.Diagnostics;
using Chapter06.Examples.Custom;

namespace Chapter06.Examples.PerformanceTraps
{
    public static class Demo
    {
        public static void Run()
        {
            // For benchmarks to be more accurate, make sure you run the seeding before anything
            // And then restart the application
            // Lazy loading is a prime example of being impacted by this inverting the intended results.
            DataSeeding.SeedDataIfWasntSeededBefore();
            // Slow-Faster example pairs
            // The title does not illustrate which you should pick
            // It rather illustrates when it becomes a problem.

            CompareExecTimes(InMemory.ChoosingAClass.Slow, InMemory.ChoosingAClass.Fast, "IEnumerable over IQueryable");
            CompareExecTimes(InMemory.MethodChoice.Slow, InMemory.MethodChoice.Fast, "equals over ==");
            CompareExecTimes(RecklessCompute.Slow, RecklessCompute.Fast, "Reckless compute");
            CompareExecTimes(Loading.Lazy, Loading.Eager, "Lazy over Eager loading");
            CompareExecTimes(LightweightEf.Default, LightweightEf.AsNoTracking, "AsNoTracking for many readonly entities");
            CompareExecTimes(MultipleAddsOrRemoves.Slow, MultipleAddsOrRemoves.Fast, "Add over AddRange");
        }

        private static void CompareExecTimes(Action slow, Action fast, string scenarioLabel)
        {
            var sw = new Stopwatch();
            sw.Start();
            slow();
            sw.Stop();
            var slowTime = sw.ElapsedMilliseconds;

            sw.Restart();
            fast();
            sw.Stop();
            var fastTime = sw.ElapsedMilliseconds;

            Console.WriteLine("{0,-40} Slow:{1,-7} Fast: {2}", 
                scenarioLabel.ToUpper(),
                slowTime+"ms,", fastTime+"ms");
        }
    }
}
