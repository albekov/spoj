using System;
using System.IO;

public class Template
{
    public static void Main()
    {
#if DEBUG
        var input = new StringReader("");
#else
        var input = Console.In;
#endif
        var output = Console.Out;
    }
}