// Output 
using System.Xml;

Console.WriteLine("");
Console.WriteLine("Welcome to the Hangman game! - Made by the one and only Merve");


// Create an array (list) of multiple words of cities  
string[] cities = { "Stockholm", "Istanbul", "London", "Singapore", "Helsinki" };

// Randomly select one word
Random rand = new Random(); // Create a Random object
int randomIndex = rand.Next(cities.Length); // Get a random index
string randomCity = cities[randomIndex];  // Access the randomly selected string

// You have 5 lives in the beginning
int lives = 5;

// Mask each letter of the word and output (e.g. Stockholm _ _ _ _ _ _ _ _ _)
string guessWord = randomCity;

string maskedGuessWord = "";

for (int i = 0; i < randomCity.Length; i++) // Goes through every letter
{
  maskedGuessWord += "_ ";
}

// Ask for one letter input from player
Console.WriteLine(" ");
Console.WriteLine("Guess a letter of the word!");
Console.WriteLine(maskedGuessWord);
Console.WriteLine(" ");
Console.WriteLine("Please enter one letter: ");
string guessedLetter = Console.ReadLine();

// Check if correct, if correct reveal the letters of the word that matches
// Check if wrong, then reduce the live of the player
bool letterGuessedCorrectly = false;

for (int i = 0; i < randomCity.Length; i++) // Goes through every letter
{
  if (randomCity[i].ToString().ToLower() == guessedLetter.ToLower())
  {
    // Update maskedGuessWord if the letter is guessed correctly
    maskedGuessWord = maskedGuessWord.Substring(0, i * 2) + guessedLetter + " " + maskedGuessWord.Substring((i * 2) + 2);
    letterGuessedCorrectly = true;
  }
}

if (!letterGuessedCorrectly)
{
  // Reduce a life if the letter is guessed incorrectly
  lives--;
  Console.WriteLine("Incorrect guess. Lives remaining: " + lives);
}


// If no lives, game over
if (lives == 0)
{
  Console.WriteLine("Game over.");
}

// If all letters correct of the word, you've won




// TODO:
// - While loop to repeat code for each guess
// - Handle win
// - Learn more about Substring