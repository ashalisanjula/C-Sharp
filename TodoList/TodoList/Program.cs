using System;

public class TodoList{

    public static string[] tasks = new string[10];

    public static int taskCount = 0;

    public static void AddTask(){
        Console.WriteLine("Enter your task: ");
        tasks[taskCount] = Console.ReadLine();
        taskCount++;
    }
       
    public static void ViewTasks(){
        for(int i=1; i<=taskCount; i++){
            Console.WriteLine( " i " + tasks[i]);
        }
    }

    public static void CompleteTask(){
        Console.WriteLine("Enter the index no that you wanted to mark as Completed: ");
        int taskNumber = int.Parse(Console.ReadLine()) -1;

        Console.WriteLine("Task number is : " +taskNumber);

        if(taskNumber>0 && taskNumber<taskCount){
        tasks[taskNumber] = tasks[taskNumber] + "Completed";
        Console.WriteLine("Task marked as Completed.");
        }
        else{
            Console.WriteLine("Invalid taskNumber.");
        }
    }

    public static void Main(){

        bool running = true;

        while (running){
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark a task as complete");
            Console.WriteLine("4. Exit");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string choice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            switch (choice){
                case "1":
                    AddTask();
                break;
                case "2":
                    ViewTasks();
                break;
                case "3":
                    CompleteTask();
                break;
                case "4":
                    running = false;
                break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }
}