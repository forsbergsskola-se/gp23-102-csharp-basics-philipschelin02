Console.WriteLine("Ok ok uhm uhm now like uhm input a numbie and I will display how many minutes and seconds it is11!!!!!!1!!!!");

int seconds = int.Parse(Console.ReadLine());

int minutes = seconds / 60;

int remainingSeconds = seconds % 60;

Console.WriteLine($"{minutes}:{remainingSeconds}");
