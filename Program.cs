IEnumerable<Task<string>> tasks = Enumerable.Range(1, 10).Select(GetValue);

await foreach(Task<string> task in Task.WhenEach(tasks))
{
    Console.WriteLine(task.Result);
}

async static Task<string> GetValue(int value)
{
    var delay = Random.Shared.Next(1, 5000);
    await Task.Delay(delay);
    return $"Done {value}";
} 