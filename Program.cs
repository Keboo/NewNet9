// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;
using System.Text.Json.Serialization;

JsonSerializerOptions options = new(JsonSerializerOptions.Default)
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    NumberHandling = JsonNumberHandling.WriteAsString,
    UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,

    RespectNullableAnnotations = true,

    RespectRequiredConstructorParameters = true,

    WriteIndented = true,
    IndentCharacter = ' ',
    IndentSize = 14,
};

string json = JsonSerializer.Serialize(
    new Person(25) { FirstName = "John", LastName = "Doe", Job = Job.Developer },
    options
    );
Console.WriteLine(json);

//NB: Missing "age" and valid vlaue for "lastName"
Person person = JsonSerializer.Deserialize<Person>(
    $$"""
    {
        "firstName": "John",
        "lastName": null,
        "job": 3
    }
    """, options);

Console.WriteLine(person);

public record Person(int Age)
{
    public string? FirstName { get; init; }
    public required string LastName { get; init; }
    public Job Job { get; init; } = Job.Developer;
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Job
{
    Unknown,
    [JsonStringEnumMemberName("bug-whisperer")]
    Developer,
    [JsonStringEnumMemberName("it-manager")]
    DigitalOverlord,
    [JsonStringEnumMemberName("creative-director")]
    WizrdOfLightbulbMoments,
    [JsonStringEnumMemberName("marketing-manager")]
    AmbassadorOfBuzz,
    [JsonStringEnumMemberName("graphic-designer")]
    PixelSorcerer 
}