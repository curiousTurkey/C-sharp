// See https://aka.ms/new-console-template for more information

using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// RandomizeAnimals();
// string[,] group = AssignGroup();
Console.WriteLine("School A");
// PrintGroup(group);

void RandomizeAnimals(){
    var random = new Random();
    int i = 0; 
    int r = random.Next(pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
}