Lotus Cybersecurity Awareness Bot

Overview

The Lotus Cybersecurity Awareness Bot is a C# console-based application designed to educate users about fundamental cybersecurity concepts in an interactive and user-friendly manner.  
The chatbot engages users through text-based interaction, enhanced with audio features and a visually appealing console interface.


Purpose

The purpose of this application is to promote cybersecurity awareness by providing users with quick, accessible information on common online threats and best practices for staying safe.


Features

- Voice Greeting (WAV File)
- 
  - Plays a pre-recorded audio message when the application starts.

- Text-to-Speech Integration
- 
  - The chatbot responds audibly using built-in speech synthesis.

- ASCII Art Interface
- 
  - Displays a branded Lotus Cybersecurity banner for improved user experience.

- Interactive Chatbot
- 
  - Responds to user queries related to:
    - Password security
    - Phishing attacks
    - Malware
    - VPNs
    - Two-Factor Authentication (2FA)
    - Firewall concepts
    - Cryptography
    - CIA Triad
    - Common cyberattacks

- Input Validation
- 
  - Ensures users provide valid input and handles errors gracefully.

- Enhanced User Experience
- 
  - Includes typing animation, colour formatting, and clear console layout.



Project Structure

The application is organised into four main classes:

- Program.cs
  
  Controls the overall execution flow of the application.

- User.cs
  
  Handles user input and validation.

- Chatbot.cs
    
  Manages chatbot interaction, responses, and UI display.

- AudioPlayer.cs
  
  Handles audio playback and text-to-speech functionality.



Technologies Used

- C# (.NET Framework 4.8)
- System.Speech (Text-to-Speech)
- System.Media (Audio playback)
- Console-based UI



Example Usage

User: What is phishing?
Bot: Phishing is when scammers trick you into giving personal information.

Future Improvements

- Expand chatbot knowledge base
- Add graphical user interface (GUI)
- Integrate natural language processing (NLP)
- Improve voice customisation options



Author

Developed by Nolulibo Songqushwa

This project is for educational purposes only.
