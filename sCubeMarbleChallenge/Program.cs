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
    else if (command =="testpalindrome")
    {
        String testString = "bob";
        char[]testArray = testString.ToCharArray();
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
        List<Marble> Marblelist = new List<Marble>();
        {
            new Marble() { ID = 1, Color = "blue", Weight = 0.5, Name = "bob" };
            new Marble() { ID = 2, Color = "red", Weight = 0.4, Name = "fred" };
            new Marble() { ID = 3, Color = "violet", Weight = 0.6, Name = "sam" };

       
        foreach (Marble marble in Marblelist) ;
        {
                Console.WriteLine(Marble);
        }
    }
    else if (command != "exit")
    {
        Console.WriteLine("Unknown command,try again");
    }
}