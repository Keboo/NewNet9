namespace NewNet9;

public class Indexer
{
    [Fact]
    public void Test1()
    {
        var history = new HistoricalEvents()
        {
            Dates =
            {
                //NB: DateTime's constructor is year, month, day
                [^1] = new DateTime(1492, 10, 12),
                [^2] = new DateTime(1776, 7, 4),
                [^3] = new DateTime(1789, 7, 14),
                [^4] = new DateTime(1861, 4, 12),
                [^5] = new DateTime(1865, 8, 9),
                [^6] = new DateTime(1950, 6, 25),
                [^7] = new DateTime(1944, 6, 6),
                [^8] = new DateTime(1969, 7, 20),
                [^9] = new DateTime(1989, 11, 9),
                [^10] = DateTime.Now
            }
        };
    }

    public class HistoricalEvents
    {
        public DateTime[] Dates = new DateTime[10];
    }
}
