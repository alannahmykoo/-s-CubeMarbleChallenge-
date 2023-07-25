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
        String cleanString = StringHelper.CleanString(testString);


        Console.WriteLine("Input: " + testString + ", Output: " + cleanString);

    }
    else if (command == "testreverse")
    {
        String testString = "reversethisstring";
        String reverseString = StringHelper.ReverseString(testString);
        Console.WriteLine("Input: " + testString + ", Output: " + reverseString);
    }
    else if (command == "testpalindrome")
    {
        String testString = "Bob O;Bob";
        bool isPalindrome = StringHelper.IsPalindrome(testString);
        Console.WriteLine("Input: " + testString + ", Palindrome: " + isPalindrome);
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


        List<Marble> sortedMarbles =  MarbleChallenge.SortAndFilter(marbleList);
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