// \u001b is the unicode escape sequence for the escape character
// \e is the new C# 13 escape character, it is equivelent to \u001b
Console.WriteLine("this is regular text");
Console.WriteLine("\e[1mThis is a bold text\e[0m");
Console.WriteLine("\e[4mThis is an underlined text\e[0m");
Console.WriteLine("\e[32mThis text is green\e[0m");
