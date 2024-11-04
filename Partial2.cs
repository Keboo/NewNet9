namespace NewNet9;

public partial class Partial
{
    //You can now also do indexers!
    public partial bool KevinIsAwesome { get => true; }

    public partial void Test1()
    {
        Assert.True(KevinIsAwesome);
    }
}
