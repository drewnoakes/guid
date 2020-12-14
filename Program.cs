using System;

var guid = Guid.NewGuid();

if (args.Length == 0)
{
    Console.WriteLine(guid);
    return 0;
}

if (args.Length == 1)
{
    var upper = args[0].ToUpper();
    switch (upper)
    {
        case "N":
        case "D":
        case "B":
        case "P":
        {
            var guidString = guid.ToString(upper);
            if (args[0] == upper)
                guidString = guidString.ToUpper();
            Console.WriteLine(guidString);
            return 0;
        }
    }
}

Console.Error.WriteLine("Usage:");
Console.Error.WriteLine();
Console.Error.WriteLine("    guid [option]");
Console.Error.WriteLine();
Console.Error.WriteLine("Where [option] is an optional single character that controls formatting:");
Console.Error.WriteLine();
Console.Error.WriteLine($"    N    {guid.ToString("N").ToUpper()}");
Console.Error.WriteLine($"    D    {guid.ToString("D").ToUpper()}");
Console.Error.WriteLine($"    B    {guid.ToString("B").ToUpper()}");
Console.Error.WriteLine($"    P    {guid.ToString("P").ToUpper()}");
Console.Error.WriteLine();
Console.Error.WriteLine("When unspecified, 'd' formatting is used. Use lowercase [option] for lowercase output.");
return 1;