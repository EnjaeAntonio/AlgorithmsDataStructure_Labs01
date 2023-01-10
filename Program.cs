/*
 * Algorithms & Data Structure Lab #1
 * Enjae Antonio
 * January 9th, 2023
 */

// char[] chars = String.ToCharArray    

Console.WriteLine("Please enter how many words you would like");
int userWordCount = Int32.Parse(Console.ReadLine()); 

while (userWordCount <= 0)
{
    Console.WriteLine("Sorry please enter a positive value");
    userWordCount = Int32.Parse(Console.ReadLine());
}

int wordCount = userWordCount;
string[] userWords = new string[userWordCount];

for (int i = 0; i < wordCount; i++)
{
    Console.Write($"Enter word {i + 1} : ");
    string enteredWords = Console.ReadLine();

    while(enteredWords.Length < 1)
    {
        Console.WriteLine("Sorry, you must have at least one character");
        enteredWords = Console.ReadLine();
    }
    userWords[i] = enteredWords;
}

Console.WriteLine("Enter a character: ");
char userChar = Console.ReadKey().KeyChar;

while (!char.IsLetter(userChar))
{
    Console.WriteLine();
    Console.WriteLine("Please enter a character");
    userChar = Console.ReadKey().KeyChar;
}

int count = 0;
string joinedWords = String.Join("", userWords);

    foreach (char c in joinedWords)
    {
        if (c == Char.ToLower(userChar))
        {
            count++;
        }
    }

Console.WriteLine();
Console.WriteLine($"The letter {userChar} occurs {count} time(s)");

if ((double)count / (double)joinedWords.Length > 0.25)
{
    Console.WriteLine($"The character {userChar} represents more than 25% of the total number of characters.");
}
else
{
    Console.WriteLine($"The character {userChar} does not represent more than 25% of the total number of characters.");
}

