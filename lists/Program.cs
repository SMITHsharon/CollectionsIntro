using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet); 
            }

            List<string> secondPlanetList = new List<string> () {"Uranus", "Neptune"};
            // List<string> secondPlanetList = new List<string>(){};
            // secondPlanetList.Add("Uranus");
            // secondPlanetList.Add("Neptune");

            planetList.AddRange(secondPlanetList);

            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");

            planetList.Add("Pluto");

            Console.WriteLine();
            Console.WriteLine("All Planets:");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet); 
            }

            List<string> rockyPlanets = planetList.GetRange(0,4);
            Console.WriteLine();
            Console.WriteLine("Rocky Planets:");
            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            planetList.Remove("Pluto");
            Console.WriteLine();
            Console.WriteLine("All Planets:");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet); 
            }

            // Dictionaries
            // Planet: Spacecraft(s) that have visited

            // var probeDictionary = new Dictionary<string,string>();
            // probeDictionary.Add("Mariner", "Mercury, Venus, Mars");
            // probeDictionary.Add("Messenger", "Merury");
            // probeDictionary.Add("Pioneer", "Jupiter, Saturn, Neptune, Uranus");
            // probeDictionary.Add("Voyager", "Jupiter, Saturn, Neptune, Uranus");
            // probeDictionary.Add("Cassini", "Jupiter, Saturn");

            var probeDictionary = new Dictionary<string, List<string>>();
            probeDictionary.Add("Mariner", new List<string> {"Mercury", "Venus", "Mars"});
            probeDictionary.Add("Messenger", new List<string> {"Merury"});
            probeDictionary.Add("Pioneer", new List <string> {"Jupiter", "Saturn", "Neptune", "Uranus"});
            probeDictionary.Add("Voyager", new List <string> {"Jupiter", "Saturn", "Neptune", "Uranus"});
            probeDictionary.Add("Cassini", new List <string> {"Jupiter", "Saturn"});

            probeDictionary["Cassini"].Add("Mars");

            // the following works with either of the above ^^^ definitions
            foreach (var planet in planetList)
            {
                string output = $"{planet}: ";
                foreach (var item in probeDictionary)
                {
                    if (item.Value.Contains(planet))
                    {
                        output += $"{item.Key}, ";
                    }
                }
                Console.WriteLine(output);
            }
            
        }
    }
}
