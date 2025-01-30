using System;
using System.ComponentModel;
using System.IO.Pipelines;

public class Program{
    public static  double Add(double a, double b){
            return a +  b;
            
    }

    public static double Sub(double a, double b){
            return a - b;
            
    }

    public static double Multipy(double a, double b){
            return a * b;
          
    }

    public static double Divid(double a, double b){
            return a/b;
            
    }

    public static double Mod(double a, double b){
            return a%b;
            
    }


    public static void Main(){

        Console.WriteLine("Enter your first Number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your second Number: ");
        double b =  Convert.ToDouble(Console.ReadLine());
    
        Console.WriteLine("Enter the option :");
        Console.WriteLine(@" 1. Add Two Numbers.");
        Console.WriteLine(" 2. Subtract Two Numbers.");
        Console.WriteLine(" 3. Multiply Two Numbers.");
        Console.WriteLine(" 4. Divid Two Numbers.");
        Console.WriteLine(" 5. Module Two Numbers.");

        double todo = Convert.ToDouble(Console.ReadLine());
        double result =0;

        switch (todo){
            case 1: 
                result=Add(a,b);
                Console.WriteLine(result);
                break;
            case 2: 
                result=Sub(a,b);
                Console.WriteLine(result);
                break;
            case 3: 
                result=Multipy(a,b);
                Console.WriteLine(result);
                break;
            case 4: 
                result=Divid(a,b);
                Console.WriteLine(result);
                break;
            case 5: 
                result=Mod(a,b);
                Console.WriteLine(result);
                break;
        }
    }
}

