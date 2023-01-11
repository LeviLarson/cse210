using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int choice = 1;
        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");

        // This while loop will prompt the user to enter a number, and then add that numebr to the list
        while(choice != 0){
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            if (input  == 0){
                break;
            }
            else {
                numbers.Add(input);
            }
        }

        // This foreach loop will count the total of all the numbers in the list. Then below it it finds the average and writes it in the console.
        int total = 0;
        int max = 0;
        foreach (int numin in numbers){
            total += numin;
            if(numin > max){
                max = numin;
            }
        }
        int min = max;
        foreach (int numin in numbers){
            if(numin < min){
                min = numin;
            }
        }

        float avg = total / numbers.Count;

        Console.WriteLine($"The average of your list is {avg}. Your largest number is {max} and your smallest number is {min}");

    }

}