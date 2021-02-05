using System;
using System.Collections.Generic;

namespace CollectionsAndLinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            var morePlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(morePlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            var rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            var solarSystemProbes = new Dictionary<string, List<string>>()
            {
                { "Earth", new List<string>() {"technically all"} },
                { "Venus", new List<string>() {"Venera 1", "Mariner 1", "Sputnik 19", "Cosmos 96"} },
                { "Uranus", new List<string>() { "Voyager 2" } },
                { "Neptune", new List<string>() { "Voyager 2", "IHP-2" } },
                { "Saturn", new List<string>() { "Voyager 1", "Pioneer 11", "Cassini" } },
                { "Jupiter", new List<string>() { "Pioneer 10", "Galileo Orbiter", "Voyager 2" } },
                { "Mercury", new List<string>() { "Mariner 10", "MESSENGER", "BepiColombo" } },
                { "Mars", new List<string>() {"Emirates Mars Mission", "Mars 2020 Perserverence", "MAVEN"} }
            };

            planetList.ForEach(planet =>
            {
                if (solarSystemProbes.TryGetValue(planet, out List<string> probes))
                {
                    Console.Write($"{planet}: ");
                    Console.Write(string.Join(", ", probes));
                    Console.WriteLine();
                }
            });
        }
    }
}
