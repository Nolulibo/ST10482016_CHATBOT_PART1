using System;
using System.Media;
using System.Speech.Synthesis;

// Handles all audio-related functionality for the chatbot including playing a pre-recorded greeting and generating speech output.
class AudioPlayer
{
    // SpeechSynthesizer instance used for text-to-speech functionality
    static SpeechSynthesizer synth = new SpeechSynthesizer();

    // Plays a WAV audio file as the initial greeting when the program starts.
    // Uses exception handling to prevent the application from crashing if the audio file is missing or fails to load.
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("LOTUS.wav");
            player.PlaySync(); // Ensures audio plays before continuing
        }
        catch
        {
            Console.WriteLine("Audio file could not be played.");
        }
    }

    // Converts text into spoken audio using text-to-speech.
    // This enhances interactivity by allowing the chatbot to "talk".
    public static void Speak(string message)
    {
        try
        {
            synth.Speak(message);
        }
        catch
        {
            // Prevents application crash if speech fails
        }
    }
}