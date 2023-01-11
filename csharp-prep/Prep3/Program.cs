using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        // Console.WriteLine($"Your random number is {number}");
        string input = "yes";
        int guesses = 0;
        while (input == "yes"){
        Console.WriteLine("Please enter your guess: ");
        guesses += 1;
        int answer = int.Parse(Console.ReadLine());
        // Console.WriteLine($"They guessed {answer}");

        
            if (answer > number ){
                Console.WriteLine("Your answer is higher");
            }

            else if (answer < number){
                Console.WriteLine("Your answer is lower ");
            }

            else {
                Console.WriteLine($"Correct. Perfect. Great job! You guessed {guesses} times.");
                input = "no";
            }
        }
    }
}