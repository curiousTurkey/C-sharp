// See https://aka.ms/new-console-template for more information
// Prompt the user for the lower and upper bounds
Console.Clear();
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

// Calculate the sum of the even numbers between the bounds
try{
    if(lowerBound >= upperBound){
        throw new Exception("lower bound cannot be equal to or greater than upper bound");
    }
} catch(Exception ex){
    Console.BackgroundColor =ConsoleColor.Red;
    Console.WriteLine("Exception occurred" + ex.Message);
}
finally{
    Console.WriteLine("Exception occurred");

}
try{
averageValue = AverageOfEvenNumbers(lowerBound, upperBound);
} catch (Exception ex){
    Console.WriteLine("Exception caight in main " + ex.Message);
}


// Display the value returned by AverageOfEvenNumbers in the console
Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    int sum = 0;
    int count = 0;
    decimal average = 0;
    try{
        for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
    }catch(DivideByZeroException ex){
        Console.WriteLine("Exception Occurred" + ex.Message);
        throw;
    }
    finally{
        Console.WriteLine("Method execution failed");
    }
}