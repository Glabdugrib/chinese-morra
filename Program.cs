Console.WriteLine("\n*** CHINESE MORRA ***");

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
else if((userPick == 1 && cpuPick == 3) || (userPick == 2 && cpuPick == 1) || (userPick == 3 && cpuPick == 2))
{
    Console.WriteLine("\nYou wins!");
}
else
{
    Console.WriteLine("\nCPU wins!");
}

