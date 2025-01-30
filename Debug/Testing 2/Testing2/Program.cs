using System;
public class Program
{
// Method to calculate the average of an array
public static double CalculateAverage(int[] numbers)
{

    if (numbers.Length == 0){
        Console.WriteLine("Error : Cannot calculate the average of an empty array.");
        return double.NaN;
    }
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum / numbers.Length;
}

public static void Main()
{
    int[] numbers = {1,2,3}; // Empty array
    double average = CalculateAverage(numbers);
    Console.WriteLine("The average is: " + average);
}
}