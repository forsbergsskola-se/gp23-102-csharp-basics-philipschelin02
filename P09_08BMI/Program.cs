using System;

Console.WriteLine("Ok ok uhm uhm now like uhm input ur height n weight and i will calculate ur bmi11!!!!!!1!!!!");

Console.WriteLine("Ok height in meters pls!!!");
string height = Console.ReadLine();
float heightInput = float.Parse(height);

Console.WriteLine("Ok ur weight in kgs pls!!!");
string weight = Console.ReadLine();
float weightInput = float.Parse(weight);

float answer = weightInput / (heightInput * heightInput);

Console.WriteLine($"Ok ok so like uhm ur {heightInput} meters tall and u weight {weightInput} kgs and that means ur bmi is {answer}!!!!");

if (answer < 18.5)
{
    Console.WriteLine("tbh ur kinda underweight. maybe swing by Donken on the way home???");
}

if (answer > 18.5 && answer < 24.9)
{
    Console.WriteLine("ur weight is perfect!!!! keep at it, ok?!?!?!?");
}

if (answer > 25 && answer < 29.9)
{
    Console.WriteLine("ok so like ngl ur kinda fat so like pls consider a gym membership, ok????");
}

if (answer > 30)
{
    Console.WriteLine("https://youtu.be/hAFlWDpOcrw?si=Aa0xCDjLOCtrs_uK");
}