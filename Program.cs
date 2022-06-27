Console.WriteLine("\n*** CHINESE MORRA ***");

// Chiedi numero di match vinti per concludere il gioco

int matchNum = 0;

do
{
    Console.Write("\nBest of: ");
    matchNum = Convert.ToInt32(Console.ReadLine());

    if(matchNum < 1)
    {
        Console.WriteLine("The number of matches must be greater or equal than 1. Try again");
    }
    else if(matchNum > 10)
    {
        Console.WriteLine("The number of matches must be lower or equal than 10. Try again");
    }
}
while (matchNum < 1 || matchNum > 10);


// LOGICA DEL GIOCO
int userScore = 0;
int cpuScore = 0;

do
{
    // User choice
    string input;
    int userPick = 0;
    bool isInputCorrect = false;

    do
    {
        Console.Write("\nChoose 'stone', 'paper' or 'scissors': ");

        input = Console.ReadLine();

        if (input == "stone" || input == "paper" || input == "scissors" || input == "Stone" || input == "Paper" || input == "Scissors")
        {
            isInputCorrect = true;

            switch (input)
            {
                case "stone":
                    userPick = 1;
                    break;
                case "Stone":
                    userPick = 1;
                    break;
                case "paper":
                    userPick = 2;
                    break;
                case "Paper":
                    userPick = 2;
                    break;
                case "scissors":
                    userPick = 3;
                    break;
                case "Scissors":
                    userPick = 3;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Wrong input! Try again");
        }
    }
    while (!isInputCorrect);


    // Cpu choice
    Random rnd = new Random();
    int cpuPick = rnd.Next(1, 4);


    // Print choices
    Console.Write($"\nUser: ");
    switch (userPick)
    {
        case 1:
            Console.Write("stone");
            break;
        case 2:
            Console.Write("paper");
            break;
        case 3:
            Console.Write("scissors");
            break;
    }

    Console.Write($"\nCPU: ");
    switch (cpuPick)
    {
        case 1:
            Console.Write("stone");
            break;
        case 2:
            Console.Write("paper");
            break;
        case 3:
            Console.Write("scissors");
            break;
    }

    Console.WriteLine();


    // Print result
    if (userPick == cpuPick)
    {
        Console.WriteLine("\nDraw");
    }
    else if ((userPick == 1 && cpuPick == 3) || (userPick == 2 && cpuPick == 1) || (userPick == 3 && cpuPick == 2))
    {
        Console.WriteLine("\nYou win the match!");
        userScore++;
    }
    else
    {
        Console.WriteLine("\nCPU wins the match!");
        cpuScore++;
    }

    Console.WriteLine($"User: {userScore} vs CPU: {cpuScore}");
}
while (userScore < matchNum && cpuScore < matchNum);

if(userScore == matchNum)
{
    Console.WriteLine("\nYOU WIN THE GAME!!");
}
else
{
    Console.WriteLine("\nCPU WINS THE GAME!!");
}