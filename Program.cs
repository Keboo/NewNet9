using System.Text.RegularExpressions;

string input = "This is a sample sentence, with punctuation.";

var words = MyRegex.WordSplitter.EnumerateSplits(input);

foreach (Range range in words)
{
    Console.WriteLine(input[range]);
}

public partial class MyRegex
{
    [GeneratedRegex(@"\W+")]
    public static partial Regex WordSplitter { get; }
}