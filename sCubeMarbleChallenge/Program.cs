// See https://aka.ms/new-console-template for more information
using System.Text;
using sCubeMarbleChallenge;

String command = "";

while (command != "exit")
{ 
Console.WriteLine("Enter a command");
command = Console.ReadLine().ToLower();
Console.WriteLine("you enter: " + command);

    if (command == "testsetup")
    {
        // Do something
    }
    else if (command == "testmarble")
    {
        Marble marble = new Marble();
        marble.ID = 1;
        marble.Name = "Bob";
        marble.Color = "Blue";
        marble.Weight = 0.5;
        Console.WriteLine(marble);
    }
    else if (command == "testclean")
    {
        String testString = "Bob o'Bob";
        String cleanString = testString.ToLower();
        char[] testArray = testString.ToCharArray();
        StringBuilder builder = new StringBuilder();

        foreach (char c in testArray)
        {
            if (char.IsLetterOrDigit(c))
            {
                builder.Append(c);
            }
        }
        cleanString = builder.ToString();
        Console.WriteLine("Input: " + testString + ", Output: " + cleanString);

    }
    else if (command == "testpalindrome")
    {
        String testString = "bob";
        char[] testArray = testString.ToCharArray();
        Array.Reverse(testArray);
        String reverseString = new String(testArray);

        bool isPalindrome = false;
        if (testString == reverseString)
        {
            isPalindrome = true;
        }

        Console.WriteLine("Input: " + testString + ", Output: " + reverseString);
    }
    else if (command == "testfilter")
    {
        List<Marble> Marblelist = new List<Marble>()
        {
            new Marble() { ID = 1, Color = "blue", Weight = 0.5, Name = "bob" } ,
            new Marble() { ID = 2, Color = "red", Weight = 0.4, Name = "fred" },
            new Marble() { ID = 3, Color = "violet", Weight = 0.6, Name = "sam" }

        };
        Console.WriteLine("Original List:");
        foreach (Marble marble in Marblelist)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

        List<Marble> filteredList = new List<Marble>();

        foreach (Marble marble in Marblelist)
        {
            String cleanString = marble.Name.ToLower();
            char[] testArray = cleanString.ToCharArray();
            StringBuilder builder = new StringBuilder();

            foreach (char c in testArray)
            {
                if (char.IsLetterOrDigit(c))
                {
                    builder.Append(c);
                }
            }
            cleanString = builder.ToString();

            testArray = cleanString.ToCharArray();
            Array.Reverse(testArray);
            String reverseString = new String(testArray);

            bool isPalindrome = false;
            if (cleanString == reverseString)
            {
                isPalindrome = true;
            }

            if (marble.Weight >= 0.5 && isPalindrome == true)
            {
                filteredList.Add(marble);
            }
        }
        Console.WriteLine("Filtered List:");
        foreach (Marble marble in filteredList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();
    }
    else if (command == "testsort") 
    {
        List<Marble> marbleList = new List<Marble>()
        {
        
            new Marble() { ID = 1, Color = "blue", Weight = 0.5, Name = "bob" } ,
            new Marble() { ID = 2, Color = "red", Weight = 0.4, Name = "fred" },
            new Marble() { ID = 3, Color = "violet", Weight = 0.6, Name = "sam" },
            new Marble() { ID = 4, Color = "indigo", Weight = 0.7, Name = "racecar" } ,
            new Marble() { ID = 5, Color = "orange", Weight = 0.5, Name = "Bob o'Bob" },
            new Marble() { ID = 6, Color = "yellow", Weight = 0.2, Name = "Bob Dad-Bob" },
            new Marble() { ID = 7, Color = "green", Weight = 1.0, Name = "Tom" }
        };
        Console.WriteLine("Original List:");
        foreach (Marble marble in marbleList)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();

        Dictionary<String, int> colorLookup = new Dictionary<string, int>()
        {
            {"red", 1},
            {"orange", 2 },
            {"yellow", 3 },
            {"green",4},
            {"blue", 5 },
            {"indigo", 6 },
            {"violet", 7 }
        };
        List<Marble> sortedMarbles = marbleList.OrderBy(m => colorLookup[m.Color]). ToList();
        Console.WriteLine("Sorted List:");
        foreach (Marble marble in sortedMarbles)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();
    }
    else if (command == "testsortandfilter")
    {
        List<Marble> marbleList = new List<Marble>()
        {

            new Marble() { ID = 1, Color = "blue", Weight = 0.5, Name = "Bob" } ,
            new Marble() { ID = 2, Color = "red", Weight = 0.25, Name = "John Smith" },
            new Marble() { ID = 3, Color = "violet", Weight = 0.5, Name = "Bob O'Bob" },
            new Marble() { ID = 4, Color = "indigo", Weight = 0.75, Name = "Bob Dad-Bob" } ,
            new Marble() { ID = 5, Color = "orange", Weight = 0.5, Name = "John" },
            new Marble() { ID = 6, Color = "yellow", Weight = 0.25, Name = "Bob" },
            new Marble() { ID = 7, Color = "green", Weight = 0.5, Name = "Smith" },
             new Marble() { ID = 8, Color = "blue", Weight = 0.25, Name = "Bob" },
            new Marble() { ID = 9, Color = "green", Weight = 0.75, Name = "Bobb Ob" },
            new Marble() { ID = 10, Color = "blue", Weight = 0.5, Name = "Bob" },

        };
        Console.WriteLine("Original List:");
    foreach (Marble marble in marbleList)
    {
        Console.WriteLine(marble);
    }
    Console.WriteLine();

    List<Marble> filteredList = new List<Marble>();

    foreach (Marble marble in marbleList)
    {
        String cleanString = marble.Name.ToLower();
        char[] testArray = cleanString.ToCharArray();
        StringBuilder builder = new StringBuilder();

        foreach (char c in testArray)
        {
            if (char.IsLetterOrDigit(c))
            {
                builder.Append(c);
            }
        }
        cleanString = builder.ToString();

        testArray = cleanString.ToCharArray();
        Array.Reverse(testArray);
        String reverseString = new String(testArray);

        bool isPalindrome = false;
        if (cleanString == reverseString)
        {
            isPalindrome = true;
        }

        if (marble.Weight >= 0.5 && isPalindrome == true)
        {
            filteredList.Add(marble);
        }
    }
  
       
       

        Dictionary<String, int> colorLookup = new Dictionary<string, int>()
        {
            {"red", 1},
            {"orange", 2 },
            {"yellow", 3 },
            {"green",4},
            {"blue", 5 },
            {"indigo", 6 },
            {"violet", 7 }
        };
        List<Marble> sortedMarbles = filteredList.OrderBy(m => colorLookup[m.Color]).ToList();
        Console.WriteLine("Sorted and Filtered List:");
        foreach (Marble marble in sortedMarbles)
        {
            Console.WriteLine(marble);
        }
        Console.WriteLine();
    }

    else if (command != "exit")
    {
        Console.WriteLine("Unknown command,try again");
    }
}