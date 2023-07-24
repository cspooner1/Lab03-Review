using System.IO;
namespace Lab04_Review;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Select the Challenge you want");
        string selection = Console.ReadLine();
        if (selection == "1")
        {
            int product = Challenge1();
        }
        if (selection == "2")
        {
            int product = Challenge2();
        }
        if (selection == "3")
        {
            Challenge3();
        }
        if (selection == "4")
        {
            Challenge4();
        }
        if (selection == "5")
        {
            Challenge5();
        }
        if (selection == "6")
        {
            Challenge6();
        }
        if (selection == "7")
        {
            Challenge7();
        }
        if (selection == "8")
        {
            Challenge8();
        }
        if (selection == "9")
        {
            Challenge9();
        }
    }

    public static int Challenge1()
    {
        Console.WriteLine("Give me 3 numbers");
        string userInput = Console.ReadLine();
        string[] numbers = userInput.Split(" ");

        if (numbers.Length < 3)
        {
            Console.WriteLine("Your Product is 0");
            return 0;
        }

        Console.WriteLine(numbers[0] + " " + numbers[1] + " " + numbers[2]);
        int firstNumber, secondNumber, thirdNumber;

        //If TryParse is true it returns a int, but if the bool is false then it returns a default value of 0;
        if (!int.TryParse(numbers[0], out firstNumber) ||
                !int.TryParse(numbers[1], out secondNumber) ||
                !int.TryParse(numbers[2], out thirdNumber))
        {
            Console.WriteLine("Your Product is 0");
            return 0;
        }

        int product = firstNumber * secondNumber * thirdNumber;
        Console.WriteLine("Your Product is {0}", product);

        //If the length of the array is greaterThan or equal to 3 return product if true & false.
        if (numbers.Length >= 3)
        {
            return product;
        }
        else
        {
            return product;
        }
    }

    public static int Challenge2()
    {
        Console.Write("Enter a number between 2-10: ");
        string userInput = Console.ReadLine();
        int userIndex = Convert.ToInt32(userInput);
        int[] numbersArray = new int[userIndex];

        if (userIndex < 2 || userIndex > 10)
        {
            return 0;
        }

        int sum = 0;
        for (int i = 0; i < userIndex; i++)
        {
            Console.Write("{0} of {1} - Enter a random number: ", i + 1, userInput);
            string newInput = Console.ReadLine();
            numbersArray[i] = Convert.ToInt32(newInput);
            sum += numbersArray[i];
        }

        int average = sum / userIndex;
        Console.WriteLine("Your Average is {0}", average);

        return 0;
    }

    public static int Challenge3()
    {
        Console.WriteLine("    *    ");
        Console.WriteLine("   ***   ");
        Console.WriteLine("  *****  ");
        Console.WriteLine(" ******* ");
        Console.WriteLine("*********");
        Console.WriteLine(" ******* ");
        Console.WriteLine("  *****  ");
        Console.WriteLine("   ***   ");
        Console.WriteLine("    *    ");
        return 0;
    }

    public static int Challenge4()
    {
        int[] numbers = new int[] { 5, 1, 5, 2, 3, 3, 5, 5, 1, 5, 5, 6, 5, 8, 2, 1, 1 };
        int mostSeen = numbers[0];
        int highestScore = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            int timesSeen = 0;
            for (int c = 0; c < numbers.Length; c++)
            {
                if (currentNumber == numbers[c]) ;
                {
                    timesSeen++;
                }
            }
            if (timesSeen > highestScore)
            {
                mostSeen = currentNumber;
                highestScore = timesSeen;
            }
        }
        Console.WriteLine($"This is the number we see the most: {mostSeen}");
        return 0;
    }

    public static int Challenge5()
    {
        int[] numbers = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
        int highestNumber = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > highestNumber)
            {
                highestNumber = numbers[i];
            }
        }
        Console.WriteLine($"This is the highest number: {highestNumber}");
        return 0;
    }

    public static int Challenge6()
    {
        string word = Console.ReadLine();
        Console.WriteLine($"Enter a word: {word}");
        File.WriteAllText("/Users/theboyz/Documents/GitHub/Lab03-Review/Lab03-Review/Lab04-Review/Words.txt", word);
        return 0;
    }

    static void Challenge7()
    {
        string contents = File.ReadAllText("/Users/theboyz/Documents/GitHub/Lab03-Review/Lab03-Review/Lab04-Review/Words.txt");
        Console.WriteLine(contents);
    }

    static void Challenge8()
    {
        string contents = File.ReadAllText("/Users/theboyz/Documents/GitHub/Lab03-Review/Lab03-Review/Lab04-Review/Words.txt");
        string[] words = contents.Split(" ");
        words[words.Length - 1] = "";
        string updatedContents = "";
        foreach (string word in words)
        {
            updatedContents += word;
        }
        File.WriteAllText("/Users/theboyz/Documents/GitHub/Lab03-Review/Lab03-Review/Lab04-Review/Words.txt", updatedContents);
    }

    static void Challenge9()
    {
        Console.WriteLine("Please enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            int numberOfLetters = words[i].Length;
            words[i] = $"{words[i]} : {numberOfLetters}";
            Console.Write($"words[i] ");
        }
    }
}

