using System;
using System.Collections.Generic;

namespace CollectionsAndLinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Mai" }, { "age", "63" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Danh" }, { "age", "70" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "David" }, { "age", "22" } });

            foreach ((string member, Dictionary<string, string> info) in myFamily)
            {

                if (info.TryGetValue("name", out string name))
                {
                    if (info.TryGetValue("age", out string age))
                    {
                        Console.WriteLine($"{name} is my {member} and is {age} years old");
                    }
                }
            }
        }
    }
}
