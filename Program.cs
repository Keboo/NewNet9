// https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-9/libraries#systemguid

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(Guid.NewGuid());
}

WriteSeparator();
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(Guid.CreateVersion7());
}

WriteSeparator();
DateTimeOffset now = DateTimeOffset.Now.AddDays(-1);
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(Guid.CreateVersion7(now));
}

static void WriteSeparator()
{
    Console.WriteLine();
    Console.WriteLine(new string('-', 40));
    Console.WriteLine();
}