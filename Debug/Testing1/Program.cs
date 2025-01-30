using System;
public class Program{
    public static double DivideNumbers(double numerator, double denominator){

        if (denominator==0){
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; 
        }
        double result = numerator/denominator;
        return result;
    }

    public static void Main(){
        double result = DivideNumbers(10,0);
        Console.WriteLine("The result is : " +result);
    }
}
