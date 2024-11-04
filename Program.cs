// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;

JsonSerializerOptions options = JsonSerializerOptions.Default;
JsonNode schema = options.GetJsonSchemaAsNode(typeof(Person));
Console.WriteLine(schema.ToString());

public record Person(string Name, int Age);