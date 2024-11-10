// See https://aka.ms/new-console-template for more information

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();

void TellFortune(){
    Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
}

int[] schedule = [800, 1200, 1600, 2000];

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT){
    int diff = 0;
if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
}
}

//PASS BY VALUE AND PASS BY REFERENCE

int a = 3;
int b = 4;
int c = 0;

Multiply(a,b,c);
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Global scope A * B = " + c);
Console.BackgroundColor = ConsoleColor.Black;
void Multiply(int a, int b, int c){
    c = a * b;
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("A * B = ".PadRight(20) + c);
}

string[] guestList = ["Rebecca", "Nadia", "Noor", "Jonte"];
string[] rsvps = new string[10];

int count = 0;
RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP(name: "Tony", partySize: 1, allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);


ShowRSVP();
//if given default values, they are optional.
void RSVP(string name, int partySize, string allergies, bool inviteOnly){
    if(inviteOnly){
        //search guestList before adding rsvp
        bool found = false;
        foreach(string guest in guestList){
            if(guest.Equals(name)){
                found = true;
                break;
            }
        }
        if(!found){
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}. \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVP(){
    Console.WriteLine("\nTotal RSVPS");
    for (int i = 0; i < count; i++){
        Console.WriteLine();
    }
}