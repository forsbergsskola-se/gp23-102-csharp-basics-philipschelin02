using System;
var random = new Random();
int aiChoice = random.Next(1, 100);
int playerTries = 0;

Console.WriteLine("Aight, buddy. Lemme be honest with ya, ya owe us quite a fat load a' cash. You nevah paid up, nor did ya ever have the intention to.");
Console.WriteLine("As a result, we sorry, but this had ta' happen. Don's orders.");
Console.WriteLine("Howevvah, lucky for you, he's decided to give yous a fightin' chance.");

ROOLZ:
Console.WriteLine("I've picked a numbah between one n' a hundred. Guess right within 10 tries, and so long as we know you'll keep ya mouth shut, the debt will be absolved, and ya may just get to see your family again.");
Console.WriteLine("Capiche?");

Answer:
string userAnswer = Console.ReadLine();
{
    if (userAnswer == "Yes")
    {
        Console.WriteLine("Aight, good. Go ahead n' guess. Ain't got all day.");
        goto GAME;
    }

    if (userAnswer == "No")
    {
        Console.WriteLine("Aight then. Lemme run ya through the rules again.");
        goto ROOLZ;
    }

    else
    {
        Console.WriteLine("You tryna be funny or somethin'? Have ya undahstood, yes o' no?");
        goto Answer;
    }
}

GAME:
int guessedNumber = Int32.Parse(Console.ReadLine());
int againGuessedNumber = Convert.ToInt32(guessedNumber);
if (playerTries == 10)
{
    Console.WriteLine("That's ten tries, friend. You didn't guess right a single time. I'm sorry it's come to this, but rules're rules, buddy. See ya on the otha side.");
    Console.WriteLine("*The last thing you see is the end of a rifle being aimed right up to your face, before your vision goes all-black.*");
    return;
}
{
    if (guessedNumber > aiChoice)
    {
        Console.WriteLine("Nuh-uh, buddy. Mah numba's lowa'.");
        playerTries++;
        goto GAME;
    }
    
    if (guessedNumber < aiChoice)
    {
        Console.WriteLine("Naw, friend. Higher.");
        playerTries++;
        goto GAME;
    }

    if (guessedNumber == aiChoice)
    {
        Console.WriteLine("Well, friend. Looks like it's ya lucky day, for ya guessed correctly. Congratulations. Before we return ya to yous family, tho, we gotta make sure ya undahstood our message.");
        Console.WriteLine("You ain't tellin' anyone of this.");
        Console.WriteLine("Not da cops, not ya family. No one, nada.");
        Console.WriteLine("We find out, we'll be comin' for ya.");
        Console.WriteLine("Do ya undahstand?");

        string answer2 = Console.ReadLine();
        {
            if (answer2 == "Yes")
            {
                Console.WriteLine("Dat's what I thought. Now only remember one thing: This lil' interaction nevah happened.");
                Console.WriteLine("*You get hit in the head by the butt of a rifle, blindfolded, and thrown into the back of a truck. You have survived the mafia this time*");
                return;
            }

            if (answer2 == "No")
            {
                Console.WriteLine("Welp, suit ya'self. We can't take no chances.");
                Console.WriteLine("*The last thing you see is the end of a rifle being aimed right up to your face, before your vision goes all-black.*");
                return;
            }
            else
            {
                Console.WriteLine("We do not take kindly to someone not takin' this seriously. Sorry, bud, but we can't risk it.");
                Console.WriteLine("*The last thing you see is the end of a rifle being aimed right up to your face, before your vision goes all-black.*");
                return;
            }
        }
    }
}