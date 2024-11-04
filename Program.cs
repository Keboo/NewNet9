using System.Text.RegularExpressions;

string input = "This is a sample sentence, with punctuation.";

string[] words = MyRegex.WordSplitter().Split(input);

foreach (string word in words)
{
    Console.WriteLine(word);
}

public partial class MyRegex
{
    [GeneratedRegex(@"\W+")]
    public static partial Regex WordSplitter();
}