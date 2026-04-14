using System;

// Represents the user interacting with the chatbot.
// This class is responsible for collecting and validating user input.
class User
{
    // Prompts the user to enter their name and ensures valid input is provided.
    // Returns a non-empty, non-null string representing the user's name.
    public string GetName()
    {
        // Prompts user for their name
        Console.Write("\nPlease enter your name: ");
        string name = Console.ReadLine();

        // Validates input to ensure it is not empty or whitespace
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Please enter a valid name: ");
            name = Console.ReadLine();
        }

        // Returns the validated name
        return name;
    }
}