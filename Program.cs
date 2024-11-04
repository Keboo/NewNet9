// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;
using System.Text.Json.Serialization;

JsonSerializerOptions options = new(JsonSerializerOptions.Default)
{
    PropertyNamingPolicy = JsonNamingPolicy.KebabCaseUpper,
    NumberHandling = JsonNumberHandling.WriteAsString,
    UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
};
JsonNode schema = options.GetJsonSchemaAsNode(typeof(Person));
Console.WriteLine(schema.ToString());

public record Person(string Name, int Age);