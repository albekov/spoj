using System;
using System.Collections.Generic;
using System.IO;

public class COINS
{
    public static void Main()
    {
#if DEBUG
        var input = new StringReader(@"12
2
1000000000");
#else
        var input = Console.In;
#endif
        var output = Console.Out;

        while (true)
        {
            var line = input.ReadLine();
            if (line == null) break;

            Console.WriteLine(Div(Convert.ToInt32(line)));
        }
    }

    private static readonly Dictionary<long, long> Cache = new Dictionary<long, long>();

    private static long Div(long i)
    {
        if (Cache.ContainsKey(i))
            return Cache[i];

        var a = i/2;
        var b = i/3;
        var c = i/4;

        var res = i >= a + b + c
            ? i
            : Div(a) + Div(b) + Div(c);

        Cache[i] = res;

        return res;
    }
}