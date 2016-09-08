using System;
using System.IO;
using System.Linq;

public class FCTRL
{
    public static void Main()
    {
#if DEBUG
        var input = new StringReader(@"6
3
60
100
1024
23456
8735373");
#else
        var input = Console.In;
#endif
        var output = Console.Out;

        var t = Convert.ToInt32(input.ReadLine());

        for (var i = 1; i <= t; i++)
        {
            var n = Convert.ToInt32(input.ReadLine());
            var l = (int) Math.Log(n, 5);
            var result = Enumerable.Range(1, l).Select(l5 => n/(int) Math.Pow(5, l5)).Sum();
            Console.WriteLine(result);
        }
    }
}