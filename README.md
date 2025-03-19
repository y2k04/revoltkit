# revoltkit
A PluralKit API bot for Revolt

## To Do
- [ ] Implement API Client
- [ ] Comment code

## General Usage
1. Create an environment variable with the name "RevoltKit_BotToken" (either in the system, or in a script file such as Batch, PowerShell, etc.) with the value of your bot token given by Revolt.
2. Run the program and the bot should come online.

## PluralKit Debug Console Usage
1. Create an environment variable called "PluralKit_Debug" and put any value except whitespace.
2. Running the program will bring you to a prompt.
3. Get your token from PluralKit via Discord using the *pk;token* command.
4. In the prompt, type: *token [paste PluralKit token here]*
5. You can now use most PluralKit commands and get their raw output.*

*Note: As of 19/03/2025, most PK commands aren't set up in the debug console.

## Environment Variables
| Variable Name | Usage |
|---------------|-------|
| RevoltKit_BotToken | Token for the bot to log into Revolt |
| PluralKit_Debug | Set to any value to enable the debug console for the PluralKit API (Note: It would not connect to Revolt.) |
