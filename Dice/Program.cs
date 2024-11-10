// See https://aka.ms/new-console-template for more information
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
string choice = "n";
choice = Console.ReadLine();
if (choice != null)
{
    if (ShouldPlay(choice))
    {
        PlayGame();
    }
}
void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = RandomValue();
        var roll = DiceRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target: target, roll: roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        choice = Console.ReadLine();
        if(choice != null)
        play = ShouldPlay(choice);
    }
}
bool ShouldPlay(string choice)
{
    return choice.ToLower() == "y" ? true : false;
}
int RandomValue(){
    var randomNumber = new Random();
    int number = randomNumber.Next(1,5);
    return number;
}

int DiceRoll(){
    var random = new Random();
    int diceRoll = random.Next(1,6);
    return diceRoll;
}

string WinOrLose(int target, int roll){
    if(roll > target){
        return "You win!";
    } else {
        return "You lose :(";
    }
}

//Another Possible Solution


/*
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}
*/