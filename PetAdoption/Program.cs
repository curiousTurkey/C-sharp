// See https://aka.ms/new-console-template for more information

// #1 the ourAnimals array will store the following: 
using System.Reflection.PortableExecutable;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";
decimal decimalDonation;
// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];
string[] searchingIcons = [".", ".. ", "... ", "...."];
string[] circlingAnimation = ["|", "/", "-", "\\", "|"];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m;
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Display all dogs with a specified characteristic");
            string[] dogCharacteristicArray = [];
            string dogCharacteristic = "";
            while (dogCharacteristic == "")
            {
                Console.WriteLine("\nEnter the desired dog characteristics seperated by commas(,)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                    dogCharacteristicArray = dogCharacteristic.Split(",");
                    Array.Sort(dogCharacteristicArray);
                }
            }
            string dogDescription = "";
            bool noMatchesDog = true;
            for (int i = 0; i < maxPets; i++)
            {
                
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    for (int k = 0; k <= 4; k++)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write($"Searching for a  - {circlingAnimation[k]}");
                    await Task.Delay(600);

                }
                    //#7
                    dogDescription = $" {ourAnimals[i, 4]} \n {ourAnimals[i, 5]}";
                    for (int j = 0; j < dogCharacteristicArray.Length; j++)
                    {
                        if (dogDescription.Contains(dogCharacteristicArray[j]))
                        {
                            //animation code

                            Console.WriteLine();
                            Console.WriteLine($"Our dog {ourAnimals[i, 3]} matches for {dogCharacteristicArray[j]}");

                        }

                    }
                    Console.WriteLine($"{ourAnimals[i, 0]} \n{ourAnimals[i, 4]} \n{ourAnimals[i, 5]}");
                    Console.WriteLine();
                    Console.WriteLine();

                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");