Console.WriteLine("Pls gib km/h input and i'll convert to m/s!!!!");

string input = Console.ReadLine();
float numberInput = float.Parse(input);
float i = numberInput * 1000 / 60 / 60;
Console.WriteLine($"omg thats {i} m/s!!!");