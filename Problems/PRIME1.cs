using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PRIME1
{
    public static void Main()
    {
#if DEBUG
        var input = new StringReader("2\n999900000 1000000000\n3 5");
#else
        var input = Console.In;
#endif
        var output = Console.Out;

        var t = int.Parse(input.ReadLine());
        var ranges = Enumerable.Range(0, t)
            .Select(i => input.ReadLine().Split(' ').Select(int.Parse).ToList())
            .Select(a => new { min = a[0], max = a[1] })
            .ToList();

        foreach (var r in ranges)
        {
            var primes = Primes(r.min, r.max);
            foreach (var p in primes)
                output.WriteLine(p);
            output.WriteLine();
        }
    }

    private static IEnumerable<int> Primes(int min, int max)
    {
        var sieve = new bool[max - min + 1];
        for (var i = 0; i < sieve.Length; i++)
            sieve[i] = true;

        if (min == 1)
            sieve[0] = false;

        for (var step = 2; step * step <= max; step++)
        {
            var start = ((min - 1) / step + 1) * step;
            for (var i = start; i <= max; i += step)
                if (i != step)
                    sieve[i - min] = false;
        }

        var result = new List<int>();
        for (var i = min; i <= max; i++)
            if (sieve[i - min])
                result.Add(i);

        return result;
    }
}
