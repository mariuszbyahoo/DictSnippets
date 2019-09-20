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

            var countries = new Dictionary<string, Country>
            {
                { norway.getCode(), norway },
                { finland.getCode(), finland }
            };

// The line of code below throws an Exception because of the lack of such a key
// in the Dictionary.
//          Console.WriteLine(countries["MUS"].getName());

            bool exists = countries.TryGetValue("MUS", out Country country);

            if (exists)
            {
                Console.WriteLine(countries["MUS"].getName());
            }
            else
            {
                Console.WriteLine("There's no country with the code MUS");
            }
        }
    }
}
