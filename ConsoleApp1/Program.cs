using System;

// Entry point of the application.
// This class controls the overall flow and interaction between the User, Chatbot, and AudioPlayer classes.
class Program
{
    static void Main()
    {
        // Sets the title of the console window for branding
        Console.Title = "Lotus Cybersecurity Awareness Bot";

        // Plays the initial voice greeting (WAV file)
        AudioPlayer.PlayGreeting();

        // Displays ASCII art logo for enhanced user interface
        Chatbot.DisplayAsciiArt();

        // Creates a User object to handle user input
        User user = new User();

        // Prompts user for their name with validation
        string userName = user.GetName();

        // Clears console for a cleaner interface before starting chat
        Console.Clear();

        // Re-displays ASCII art after clearing screen
        Chatbot.DisplayAsciiArt();

        // Displays personalised welcome message
        Console.WriteLine($"\nWelcome, {userName}");

        // Uses text-to-speech to greet the user audibly
        AudioPlayer.Speak($"Welcome {userName} to Lotus Cybersecurity Awareness Bot");

        // Starts chatbot interaction loop
        Chatbot.StartChat(userName);
    }
}