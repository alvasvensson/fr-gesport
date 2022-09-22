

string[] answers = { "1", "2", "3" };

string playAgain = "yes";
while (playAgain == "yes")
{
    int points = 0;

    string name;

    Console.WriteLine(@" ^~^  ;");
    Console.WriteLine(@"('Y') )");
    Console.WriteLine(@"/   \/");
    Console.WriteLine(@"(\|||/)");

    Console.WriteLine("Welcome to my quiz, whats your name?");
    name = Console.ReadLine();

    //---------------------------------------

    Console.WriteLine("First question: How much of its awake time does a cat spen cleaning itself? ");
    Console.WriteLine("1. 20% 2. 30% 3. 40%");

    string answer1 = Console.ReadLine();

    while (!answers.Contains(answer1))
    {
        Console.WriteLine("Fel format, använd siffror");
        answer1 = Console.ReadLine();
    }

    if (answer1 == "2")
    {
        points++;
        Console.WriteLine("correct!");
    }
    else
    {
        Console.WriteLine("incorrect!");
    }

    //-----------------------------------------


    string answer2 = "";

    Console.WriteLine("question 2: What colour is polar bears' skin?");
    Console.WriteLine("1. black 2.white 3.pink");

    answer2 = Console.ReadLine();

    while (!answers.Contains(answer2))
    {
        Console.WriteLine("Fel format, använd siffror");
        answer2 = Console.ReadLine();
    }

    while (answer2 != "1")
    {
        Console.WriteLine("try again!");
        answer2 = Console.ReadLine();

    }

    if (answer2 == "1")
    {
        points++;
        Console.WriteLine("correct!");
    }
    else
    {
        Console.WriteLine("incorrect!");
    }

    //-------------------------------------------

    Console.WriteLine("Question 3: What animal is the only one that can't jump?");
    Console.WriteLine("1. elefant 2.gris 3.hamster");

    string answer3 = Console.ReadLine();

    while (!answers.Contains(answer3))
    {
        Console.WriteLine("Fel format, använd siffror");
        answer3 = Console.ReadLine();
    }

    if (answer3 == "1")
    {
        points++;
        Console.WriteLine("correct!");
    }
    else
    {
        Console.WriteLine("incorrect!");
    }

    //------------------------------------------


    Console.WriteLine($"you got {points} points");
    if (points == 0)
    {
        Console.WriteLine($"thats bad {name}");
    }

    if (points == 1)
    {
        Console.WriteLine($"that wasnt great {name}...");
    }

    if (points == 2)
    {
        Console.WriteLine($"thats decent {name}");
    }

    if (points == 3)
    {
        Console.WriteLine($"great job! {name}!");
    }

    //-------------------------------------------------

    Console.WriteLine("Do you wanna play again?");

    playAgain = Console.ReadLine();



}