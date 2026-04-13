using System;
using System.Threading;

// Handles all chatbot-related functionality including user interaction, response generation, and user interface enhancements.
class Chatbot
{
    // Displays ASCII art banner to enhance the visual appeal and branding of the chatbot interface.
    public static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine("===============================================");
        Console.WriteLine(@"
                   ██╗      ██████╗ ████████╗██╗   ██╗███████╗
                   ██║     ██╔═══██╗╚══██╔══╝██║   ██║██╔════╝
                   ██║     ██║   ██║   ██║   ██║   ██║███████╗
                   ██║     ██║   ██║   ██║   ██║   ██║╚════██║
                   ███████╗╚██████╔╝   ██║   ╚██████╔╝███████║
                   ╚══════╝ ╚═════╝    ╚═╝    ╚═════╝ ╚══════╝

                         CYBERSECURITY AWARENESS BOT 
");
        Console.WriteLine("===============================================");
    }

    // Starts the chatbot interaction loop, continuously accepting user input until the user chooses to exit the application.
    public static void StartChat(string userName)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nAsk a question Queen, (or King, we don't discriminate) (type 'exit' to quit): ");
            Console.ResetColor();

            // Reads user input from console
            string input = Console.ReadLine();

            // Trims whitespace and standardise input to lowercase for consistent processing
            if (input != null)
            {
                input = input.Trim().ToLower();
            }

            // Handles empty or invalid input
            if (string.IsNullOrWhiteSpace(input))
            {
                Respond("I didn’t catch that. Please try again.");
                continue;
            }

            // Exits condition for chatbot loop
            if (input == "exit")
            {
                Respond($"Goodbye {userName}, stay safe online!");
                break;
            }

            // Processes valid user input
            HandleResponse(input);
        }
    }

    // Determines the appropriate response based on user input using a switch-case structure with pattern matching.
    static void HandleResponse(string input)
    {
        switch (input)
        {
            case string s when s.Contains("how are you"):
                Respond("I am doing great, thank you. Let's get started.");
                break;

            case string s when s.Contains("what is your purpose"):
                Respond("I am here to help you learn about cybersecurity and how to stay safe online.");
                break; 

            case string s when s.Contains("what can i ask about"):
                Respond("You can ask me about cybersecurity topics like password security, phishing, malware, VPNs, two-factor authentication, common cyberattacks, encryption vs hashing, the CIA triad, and firewall setup.");
                break;

            case string s when s.Contains("password") && s.Contains("attack"):
                Respond("A password attack is when someone tries to steal or guess your password using methods like brute force or phishing.");
                break;

            case string s when s.Contains("password"):
                Respond("A password is a secret string of characters—including letters, numbers, or symbols—used to authenticate a user's identity and grant secure access to devices, accounts, or data. It serves as a primary defense against unauthorised access, commonly used in logins for email, social media, and financial services.");
                break;

            case string s when s.Contains("phishing"):
                Respond("It is a cyberattack in which malicious actors employ deceptive emails or messages to deceive individuals into disclosing sensitive information.");
                break;

            case string s when s.Contains("malware"):
                Respond("Malware is harmful software designed to damage or gain unauthorised access to systems (e.g., viruses, worms, trojans).");
                break;

            case string s when s.Contains("ransomware"):
                Respond("Ransomware is a type of malware that locks your files and demands payment to unlock them.");
                break;

            case string s when s.Contains("brute force attack"):
                Respond("A brute force attack is when hackers try many password combinations until they find the correct one.");
                break;

            case string s when s.Contains("social engineering"):
                    Respond("Social engineering is when attackers manipulate people into giving away confidential information.");
                break;

            case string s when s.Contains("virus"):
                Respond("A virus is a type of malware that spreads by attaching itself to files or programs.");
                break;

            case string s when s.Contains("trojan horse"):
                Respond("A trojan horse is a type of malware that disguises itself as legitimate software to trick users into installing it.");
                break;

            case string s when s.Contains("multi-factor authentication"):
                Respond("Multi-factor authentication (MFA) is a security method that requires users to provide two or more forms of verification to access an account, enhancing protection against unauthorized access.");
                break;

            case string s when s.Contains("vpn"):
                Respond("A Virtual Private Network encrypts and secures internet connections, ensuring privacy and anonymity. It protects data from eavesdropping, restricts access to content, and enhances public Wi-Fi security.");
                break;

            case string s when s.Contains("2fa"):
                Respond("Two-factor authentication enhances security by necessitating users to furnish two distinct forms of verification, typically a password and a temporary code, thereby bolstering protection.");
                break;

            case string s when s.Contains("common cyberattacks"):
                Respond("Following are some common cyber attacks:\n1 Malware\n2 Phishing\n3 Password Attacks\n4 DDoS\n5 Man in the Middle\n6 Drive-By Downloads\n7 Malvertising\n8 Rogue Software.");
                break;

            case string s when s.Contains("cyberattack"):
                Respond("A cyber attack is a deliberate, malicious attempt by individuals or groups to breach, disrupt, or damage computer systems, networks, or digital devices.");
                break;

            case string s when s.Contains("hacker"):
                Respond("A hacker is someone who tries to gain access to systems or data. They can be ethical (white hat) or malicious (black hat).");
                break;

            case string s when s.Contains("password attack"):
                Respond("A password attack is when someone tries to steal or guess your password using methods like brute force or phishing.");
                break;

            case string s when s.Contains("encryption") && s.Contains("hashing"):
                Respond("Encryption converts data into a form that can be reversed using decryption, while hashing is a one-way process that cannot be reversed.");
                break;

            case string s when s.Contains("cia triad"):
                Respond("CIA stands for Confidentiality, Integrity, and Availability.\nConfidentiality ensures only authorised access.\nIntegrity ensures data is not altered.\nAvailability ensures data is accessible when needed.");
                break;

            case string s when s.Contains("steps") && s.Contains("firewall"):
                Respond("Steps to set up a firewall:\n1 Change default credentials\n2 Disable remote access\n3 Configure port forwarding\n4 Manage DHCP settings\n5 Enable logging\n6 Apply security policies");
                break;

            case string s when s.Contains("firewall"):
                Respond("A firewall is a network security system that monitors and controls incoming and outgoing traffic to protect systems from threats.");
                break;

            case string s when s.Contains("cryptography"):
                Respond("Cryptography is the practice of securing information to protect it from unauthorised access.");
                break;

            // Default response for unrecognised input
            default:
                Respond("I didn’t understand that. Try asking about cybersecurity topics.", ConsoleColor.Red);
                break;
        }
    }

    // Handles displaying the response with a typing animation and triggers text-to-speech output.
    static void Respond(string message, ConsoleColor color = ConsoleColor.Green)
    {
        Console.ForegroundColor = color;
        TypeEffect(message);
        Console.ResetColor(); //To reset after printing
        AudioPlayer.Speak(message);
    }

    // Simulates a typing effect by printing characters one at a time, improving user experience and engagement.
    static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
        Console.WriteLine();
    }
}