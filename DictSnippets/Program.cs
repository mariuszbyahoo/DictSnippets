using System;
using System.Collections.Generic;

namespace DictSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_511_303);

            var countries = new Dictionary<string, Country>();

            countries.Add(norway.getCode(), norway);
            countries.Add(finland.getCode(), finland);


            foreach (var country in countries)
            {
                Console.WriteLine(country.Value.getName());
            }
        }
    }
}
