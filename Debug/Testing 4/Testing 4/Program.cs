﻿using System;

public class Program{

public static int FindMax(int[] numbers){
    int max = int.MinValue;
    for(int i=0; i<numbers.Length;i++){
        if (numbers[i] > max){
            max= numbers[i];
        }
    }
    return max;
}

public static void Main(){
    int[] myNumbers ={-1,-2,-3};
    int maxNumber = FindMax(myNumbers);
    Console.WriteLine("The maximum number is: " +maxNumber);
}
}