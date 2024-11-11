// See https://aka.ms/new-console-template for more information
// try
// {
//     // Step 1: code execution begins
//     try
//     {
//         // Step 2: an exception occurs here
//     }
//     finally
//     {
//         // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
//     }

// }
// catch // Step 3: the system finds a catch clause that can handle the exception
// {   
//    // Step 5: the system transfers control to the first line of the catch code block
// }

// string[] names = ["Dog", "Cat", "Fish"];
// Object[] objs = (Object[])names;

// Object obj = (Object)13;
// objs[2] = obj;
// inputValues is used to store numeric values entered by a user
checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");