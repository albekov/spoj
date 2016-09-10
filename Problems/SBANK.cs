using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SBANK
{
    public static void Main()
    {
#if DEBUG
        var input = new StringReader(@"2
6
03 10103538 2222 1233 6160 0142
03 10103538 2222 1233 6160 0141
30 10103538 2222 1233 6160 0141
30 10103538 2222 1233 6160 0142
30 10103538 2222 1233 6160 0141
30 10103538 2222 1233 6160 0142

5
30 10103538 2222 1233 6160 0144
30 10103538 2222 1233 6160 0142
30 10103538 2222 1233 6160 0145
30 10103538 2222 1233 6160 0146
30 10103538 2222 1233 6160 0143");
#else
        var input = Console.In;
#endif
        var output = Console.Out;

        var t = Convert.ToInt32(input.ReadLine());

        for (var i = 0; i < t; i++)
        {
            var line = input.ReadLine();
            var n = Convert.ToInt32(line);

            var dict = new Dictionary<string, int>();
            for (var j = 0; j < n; j++)
            {
                var a = input.ReadLine();

                if (dict.ContainsKey(a))
                    dict[a]++;
                else
                    dict[a] = 1;
            }

            var accs = dict.Keys.OrderBy(s => s);

            foreach (var acc in accs)
            {
                Console.WriteLine($"{acc} {dict[acc]}");
            }

            Console.WriteLine();

            if (i != t - 1)
                input.ReadLine();
        }
    }
}