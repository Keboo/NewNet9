namespace NewNet9;

public class ParamsTests
{
    [Fact]
    public void CanJoinStrings()
    {

        Assert.Equal("Hello World", Join("Hello", "World"));
    }

    [Fact]
    public void CanJoinStringsFromList()
    {
        var strings = GetStrings();
        Assert.Equal("Hello World", Join(strings.ToArray()));
    }

    private static List<string> GetStrings()
    {
        return ["Hello", "World"];
    }

    private static string Join(params string[] strings)
    {
        return string.Join(" ", strings);
    }
}
