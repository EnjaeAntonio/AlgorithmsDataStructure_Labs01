/*
 * Algorithms & Data Structure Lab #1
 * Enjae Antonio
 * January 9th, 2023
 */

// char[] chars = String.ToCharArray

Console.WriteLine("Please enter how many words you would like");


int wordCountInput = Int32.Parse(Console.ReadLine()); // Console.ReadLine doesnt work alone because it is a string.
string[] userWords = new string[wordCountInput];


while (wordCountInput <= 0)
{
    Console.WriteLine("Sorry please enter a positive value");
    wordCountInput = Int32.Parse(Console.ReadLine());
}

int wordCount = wordCountInput;

for (int i = 0; i < wordCount; i++)
    {
        Console.Write($"Enter word {i + 1} : ");
        userWords[i] = Console.ReadLine();
    }


Console.WriteLine("Enter a character: ");
char userChar = Console.ReadKey().KeyChar;

int count = 0;
int totalChars = 0;

foreach (string word in userWords)
{
    totalChars += word.Length;
    foreach (char c in word)
    {
        if (c == userChar)
        {
            count++;
        }
    }
}
    
Console.WriteLine();
Console.WriteLine($"The word {userChar} occurs {count} times");

if (count / (double)totalChars > 0.25)
{
    Console.WriteLine($"The character {userChar} represents more than 25% of the total number of characters.");
}
else
{
    Console.WriteLine($"The character {userChar} does not represent more than 25% of the total number of characters.");
}

