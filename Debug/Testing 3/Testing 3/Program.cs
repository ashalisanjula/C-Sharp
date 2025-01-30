using System;

public class Program
{
// Method to calculate the final price after a discount
public static double ApplyDiscount(double price, double discountPercentage)
{
    double discountamount = price * (discountPercentage/100);
    return price - discountamount;
}

public static void Main()
{
    double finalPrice = ApplyDiscount(1000, 15);
    Console.WriteLine("The final price is: " + finalPrice);
}
}
