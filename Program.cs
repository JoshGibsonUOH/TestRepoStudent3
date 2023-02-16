// See https://aka.ms/new-console-template for more information
string[] words = { "apple", "banana", "cherry", "dragonfruit", "elderberry", "fig" };

Random rand = new Random();
string wordToGuess = words[rand.Next(0, words.Length)];

char[] displayWord = new char[wordToGuess.Length];

for (int i = 0; i < wordToGuess.Length; i++)
{
    displayWord[i] = '_';
}

int guessesRemaining = 6;

while (guessesRemaining > 0)
{
    Console.WriteLine("Guess the word: " + new string(displayWord));

    Console.WriteLine("Guesses remaining: " + guessesRemaining);

    Console.Write("Guess a letter: ");
    char guess = Console.ReadLine()[0];

    bool correctGuess = false;

    for (int i = 0; i < wordToGuess.Length; i++)
    {
        if (wordToGuess[i] == guess)
        {
            displayWord[i] = guess;
            correctGuess = true;
        }
    }

    if (!correctGuess)
    {
        guessesRemaining--;
    }

    if (new string(displayWord) == wordToGuess)
    {
        Console.WriteLine("You won! The word was " + wordToGuess);
        break;
    }
}

if (guessesRemaining == 0)
{
    Console.WriteLine("You lost! The word was " + wordToGuess);
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
        
