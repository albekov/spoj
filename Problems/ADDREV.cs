using System;
using System.IO;
using System.Linq;

public class ADDREV
{
    public static void Main()
    {
#if DEBUG
        var input = new StringReader(@"3
24 1
4358 754
305 794");
#else
        var input = Console.In;
#endif
        var output = Console.Out;

        var t = int.Parse(input.ReadLine());
        var results = Enumerable.Range(0, t)
            .Select(i => Reverse(input.ReadLine()))
            .Select(line => line.Split(' ').Select(int.Parse).ToList())
            .Select(arr => int.Parse(Reverse((arr[0] + arr[1]).ToString())))
            .ToList();

        foreach (var result in results)
            output.WriteLine(result);
    }

    private static string Reverse(string s)
    {
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}