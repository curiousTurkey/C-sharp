// See https://aka.ms/new-console-template for more information

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    int j = 0;
    EmployeeEmail(corporate[i,j], corporate[i,j+1]);
    // display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    EmployeeEmail(external[i,0], external[i,1], externalDomain);
}

void EmployeeEmail(string firstName, string lastName, string domain = "contoso.com"){
    string email = "";
    email = firstName.Remove(2).ToLower();
    email += lastName.ToLower() + "@" + domain;
    Console.WriteLine(email);
}