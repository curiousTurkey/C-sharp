// See https://aka.ms/new-console-template for more information

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};


bool ValidateLength(string ipv4Input) {
    string[] address = ipv4Input.Split(".");
    bool isValidLength = address.Length == 4;
    return isValidLength;
}
bool ValidateZeroes(string ipv4Input) {
    string[] address = ipv4Input.Split(".");
    bool validZeroes = false;
    foreach(string number in address){
        if(number.StartsWith('0') && number.Length > 1){
            validZeroes = false;
            return validZeroes;
        } else {
            validZeroes = true;
        }
    }
    return validZeroes;
}
bool ValidateRange(string ipv4Input) {
    string[] address = ipv4Input.Split(".");
    int num;
    bool validRange = false;
    foreach (string number in address)
    {
        if(int.TryParse(number, out num)){
            if(num >= 0 && num <= 255){
                validRange = true;
            } else {
                validRange = false;
                return validRange;
            }
        } else {
            return false;
        }
    }
    return validRange;
}
foreach (string ip in ipv4Input)
{
    

if (ValidateLength(ip) && ValidateZeroes(ip) && ValidateRange(ip)) 
{
    Console.WriteLine($"{ip} is a valid IPv4 address");
} 
else 
{
    Console.WriteLine($"{ip} is an invalid IPv4 address");
}
}