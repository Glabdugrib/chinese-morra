Console.WriteLine("\n*** CHINESE MORRA ***");

// Chiedi numero di match vinti per concludere il gioco

int matchNum = 0;
int maxMatch = 5; // limite massimo partite

do
{
    Console.Write("\nBest of: ");
    matchNum = Convert.ToInt32(Console.ReadLine());

    if(matchNum < 1)
    {
        Console.WriteLine("The number of matches must be greater or equal than 1. Try again");
    }
    else if(matchNum > maxMatch)
    {
        Console.WriteLine($"The number of matches must be lower or equal than {maxMatch}. Try again");
    }
}
while (matchNum < 1 || matchNum > maxMatch);


// LOGICA DEL GIOCO
int userScore = 0;
int cpuScore = 0;
string[] matchSaves = new string[100];
matchSaves[0] = "Match\t\tYou\t\tCPU\t\tWinner";
int matchCounter = 1; // contatore partita

do
{
    // Scelta utente
    string input;
    bool isInputCorrect = false;

    Console.Write("\n***\n");

    do
    {
        Console.Write("\nChoose 'stone', 'paper' or 'scissors': ");

        input = Console.ReadLine().ToLower();

        if (input == "stone" || input == "paper" || input == "scissors")
        {
            isInputCorrect = true;
        }
        else
        {
            Console.WriteLine("Wrong input! Try again");
        }
    }
    while (!isInputCorrect);


    // Scelta cpu
    Random rnd = new Random();
    int cpuPick = rnd.Next(1, 4);
    string cpuInput = "stone";

    switch (cpuPick)
    {
        case 1:
            cpuInput = "stone";
            break;
        case 2:
            cpuInput = "paper";
            break;
        case 3:
            cpuInput = "scissors";
            break;
    }


    // Stampa scelte
    Console.Write($"\nUser: {input}");

    Console.Write($"\nCPU: {cpuInput}");

    Console.WriteLine();


    // Stampa risultato
    string result = "draw";

    if (input == cpuInput)
    {
        Console.WriteLine("\nDraw");
    }
    else if ((input == "stone" && cpuInput == "scissors") || (input == "paper" && cpuInput == "stone") || (input == "scissors" && cpuInput == "paper"))
    {
        result = "user";
        Console.WriteLine("\nYou win the match!");
        userScore++;
    }
    else
    {
        result = "cpu";
        Console.WriteLine("\nCPU wins the match!");
        cpuScore++;
    }

    // Salva scelte
    matchSaves[matchCounter] = $"{matchCounter}\t\t{input}\t{(input != "scissors" ? "\t" : "")}{cpuInput}\t{(cpuInput != "scissors" ? "\t" : "")}{result}";
    matchCounter++;

    Console.WriteLine($"User: {userScore} vs CPU: {cpuScore}");
}
while (userScore < matchNum && cpuScore < matchNum);


// stampa vincitore del gioco
Console.Write("\n***\n***\n");

if (userScore == matchNum)
{
    Console.WriteLine("\nYOU WIN THE GAME!!");
}
else
{
    Console.WriteLine("\nCPU WINS THE GAME!!");
}


// stampa scelte di tutte le partite
Console.WriteLine();

for (int i = 0; i < matchSaves.Length; i++)
{
    if(matchSaves[i] != null)
    {
        Console.WriteLine(matchSaves[i]);
    }
}