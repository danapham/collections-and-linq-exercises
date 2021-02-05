using System;
using System.Collections.Generic;

namespace CollectionsAndLinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var numbers = new List<int>();
            for (var i = 0; i < 20; i++)
            {
            numbers.Add(random.Next(1, 50));
            }
            var squared = new List<int>();
            numbers.ForEach(number => squared.Add(number * number));
            squared.RemoveAll(number => number % 2 != 0);
        }
    }
}
