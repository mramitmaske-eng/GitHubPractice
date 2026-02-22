using System;
using System.Linq;

namespace practice { 

    class practice
    {

       public static void Main(String[] args)
        {
            var input = Console.ReadLine();

            var output = input.GroupBy(c => c)
                            .Select(g => new
                            {
                                character = g.Key,
                                frequency = g.Count()
                            });

            foreach(var freq in output)
            {
                Console.WriteLine($"{freq.character}-{freq.frequency}");
            }

        }
    }
}
