
TimeSpan timeSpan1 = TimeSpan.FromSeconds(value: 101.832);
Console.WriteLine($"timeSpan1 = {timeSpan1}");

TimeSpan timeSpan2 = TimeSpan.FromSeconds(value: 101) + TimeSpan.FromMilliseconds(832);
Console.WriteLine($"timeSpan2 = {timeSpan2}");
