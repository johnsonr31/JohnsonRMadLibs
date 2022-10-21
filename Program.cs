// Richard Johnson
// 10-18-22

// This is where we declare our variables
bool playAgain = true;
bool isNum;
int num;



    // This will print some words to the console
    Console.Clear();
    Console.WriteLine("Do you want to create a story?");
// This while loop will continue running as long as playAgain is true
while(playAgain == true)
{
    // This will take the user's input to see if they want to start
    Console.Write("YES or NO: ");
    // The user's input will be taken, and it will be converted to all uppercase
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
    isNum = Int32.TryParse(yesNo, out num);
        if(yesNo == "NO" && isNum != true)
        {
            Console.WriteLine("Then goodbye.");
            playAgain = false;
        }
        // If the player types yes, the program will move on to asking for inputs, which will all be converted to strings
        else if(yesNo == "YES" && isNum != true)
        {
            Console.WriteLine("Alright");
            Console.Write("Please enter a name: ");
            string name1 = Console.ReadLine();


            Console.WriteLine(" ");
            Console.Write("Enter a color: ");
            string color1 = Console.ReadLine();

            Console.WriteLine(" ");
            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Enter an animal: ");
            string animal1 = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Enter another name: ");
            string name2 = Console.ReadLine();
            
            Console.WriteLine("");
            Console.Write("Enter a noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Enter a verb: ");
            string verb1 = Console.ReadLine();
            
            Console.WriteLine("");
            Console.Write("Enter a location: ");
            string location1 = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Enter an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Enter an animal (plural): ");
            string animal2 = Console.ReadLine();
            
            Console.WriteLine("");
            Console.Write("Enter an verb ending with -ing: ");
            string verb2 = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Enter an adjective ending with -ly: ");
            string adjective2 = Console.ReadLine();


        // The words that were entered and converted to strings will be printed to the console, filling the blank areas in the story
        Console.WriteLine($"There was once a person named {name1} who lived in a {color1} {noun1} out in the woods. One day, ");
        Console.WriteLine($"{name1} woke up to find a {animal1} knocking at his door. The {animal1} was named {name2}, ");
        Console.WriteLine($"and was here to tell {name1} about a magic {noun2} that could {verb1}. {name1} agreed to find ");
        Console.WriteLine($"the {noun2}, and {name2} helped guide him. They would travel to the {location1} which was in {country}, ");
        Console.WriteLine($"where they would encounter a group of {adjective1} {animal2}. The {animal2} were also looking for ");
        Console.WriteLine($"{noun2}, and held {name1} and {name2} captive. {name1} and {name2} managed to {verb2} to escape ");
        Console.WriteLine($"from them, and managed to reach the {location1}. They got in and found the magic {noun2}, and lived ");
        Console.WriteLine($"{adjective2} ever after.");
        Console.WriteLine(" ");
        // After the story is printed to the console, the player will be asked if they want to play again, 
        // and the program will loop back to the YES or NO choice from the beginning
        Console.WriteLine("Do you want to go again?");
        }
        else
        {
            // If the user types something aside from YES or NO, the text below will print, and the loop will begin again
            Console.WriteLine("Invalid Input.");
        }
}