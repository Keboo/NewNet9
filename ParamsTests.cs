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
        Assert.Equal("Hello World", Join(strings));
    }

    private static List<string> GetStrings()
    {
        return ["Hello", "World"];
    }

    private static string Join(params IEnumerable<string> strings)
    {
        return string.Join(" ", strings);
    }

    private static string Join(params ReadOnlySpan<string?> strings)
    {
        return string.Join(" ", strings);
    }
}
