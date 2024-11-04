namespace NewNet9;

public class LinqTests
{
    [Fact]
    public void JNames()
    {
        var people = GetPeople();
        var jGroup = people.GroupBy(p => p.Name[0]).First();
        Assert.Equal(10, jGroup.Count());
    }

    [Fact]
    public void Ages()
    {
        var people = GetPeople();
        var ages = people.GroupBy(p => p.Name[0]).Select(g => g.Select(p => p.Age).Sum());
        Assert.Equal([375, 21], ages.ToList());
    }

    private static List<Person> GetPeople()
    {
        return
        [
            new Person { Name = "John", Age = 25 },
            new Person { Name = "Jane", Age = 30 },
            new Person { Name = "Joe", Age = 20 },
            new Person { Name = "Jake", Age = 15 },
            new Person { Name = "Jill", Age = 40 },
            new Person { Name = "Jack", Age = 50 },
            new Person { Name = "Jen", Age = 35 },
            new Person { Name = "Jude", Age = 45 },
            new Person { Name = "Jade", Age = 55 },
            new Person { Name = "Jules", Age = 60 },
            new Person { Name = "Kevin", Age = 21 }
        ];
    }

    private class Person
    {
        public required string Name { get; set; }
        public required int Age { get; set; }
    }
}
