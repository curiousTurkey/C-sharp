// // See https://aka.ms/new-console-template for more information
// string message = "Find what is (inside the parentheses)";


// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition + 1, length - 1));

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));
// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1); //if no length provided, substring will take every characters from the starting index to end
// }
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols); //searches for multile characters present in an array in a string
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition); //can specify the starting index
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

//Remove() and Replace()
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message2 = "This--is--ex-amp-le--da-ta";
message2 = message2.Replace("--", " ");
message2 = message2.Replace("-", "");
Console.WriteLine(message2);

//challenge starter code: 

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int position = input.IndexOf("<span>");
int end = input.IndexOf("</span");
int mid = input.IndexOfAny(['e']);
Console.WriteLine(mid);
string openDiv = "<div>";
string closingDiv = "</div>";

quantity = $"Quantity: {input.Substring(position + 6 , (end - (position + 6)))}";

output = input.Replace("&trade;","&reg;");
output = output.Remove(0, (openDiv.Length));
output = output.Remove((output.Length - closingDiv.Length), closingDiv.Length);
Console.WriteLine(quantity);
Console.WriteLine(output);