using System;

Console.WriteLine("Ok ok ok uhm final exercise uhmmm so liek gimme a numbie of seconds?!?!?!?");

int seconds = int.Parse(Console.ReadLine());
float totalDays = (float)seconds / 86400;

int days = seconds/86400;
seconds = seconds % 86400;
Console.WriteLine($"Days: {days}");

int hours = seconds/3600;
seconds = seconds % 3600;
Console.WriteLine($"Hours: {hours}");

int minutes = seconds / 60;
seconds = seconds % 60;
Console.WriteLine($"Minutes: {minutes}");

Console.WriteLine($"Seconds: {seconds % 60}");

Console.WriteLine($"{days}.{hours}:{minutes}:{seconds}");

Console.WriteLine($"In total, that's {totalDays} days!!!");