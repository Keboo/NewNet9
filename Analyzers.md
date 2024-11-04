# Analyzers

## CA2264 Do not pass a non-nullable value to 'ArgumentNullException.ThrowIfNull'
https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2264?WT.mc_id=DT-MVP-5003472

```csharp
static void Foo(int value)
{
    ArgumentNullException.ThrowIfNull(value);
}
```

## CA1514 Avoid redundant length argument
https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1514?WT.mc_id=DT-MVP-5003472

```csharp
string message = "Hello World!";
string world = message.Substring(6, message.Length - 6);  // "World!"
```

## CA2022: Avoid inexact read with Stream.Read
https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2022?WT.mc_id=DT-MVP-5003472

```csharp
void ReadData(Stream stream, byte[] buffer)
{
    stream.Read(buffer, 0, buffer.Length);
    // Check return value or use ReadExactly
}
```

## CA1515: Consider making public types internal
https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1515?WT.mc_id=DT-MVP-5003472

