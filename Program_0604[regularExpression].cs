using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

public class RegularEx
{
    public void print(string input, string pattern)
    {
        foreach (Match match in Regex.Matches(input, pattern))
            Console.WriteLine(match.Value);
    }
    public static void Main()
    {
        string input = "gd8h218932y8dhes021h s027gd0721w@$! D31df3789d 13r!#F13d78g1 7827et2@$#%RGF#$%@RF1qw dg12e182hdddie46r38rf6";
        string pattern_1 = @"(?=.*[a-z].*[0-9]).*";                             // ?= exp means match exp       .* means random string
        string pattern_2 = @"\w+\d";                             // \w match letters, \d match numbers
        string pattern_3 = @"\d*";                             // match random times numbers.
        RegularEx ex = new RegularEx();
        Console.WriteLine("\ncontain letters and numbers\n");
        ex.print(input, pattern_1);
        Console.WriteLine("\nonly letters and numbers\n");
        ex.print(input, pattern_2);
        Console.WriteLine("\nonly continous numbers\n");
        ex.print(input, pattern_3);
    }
}