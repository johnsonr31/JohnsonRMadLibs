// Richard Johnson
// 10-18-22
//

bool playAgain = true;

// This while loop will continue running as long as playAgain is true
while(playAgain == true)
{
    // This will print some words to the console, and take the user's input
    Console.WriteLine("Do you want to create a story?");
    Console.Write("YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
        if(yesNo == "NO")
        {
            Console.WriteLine("Then goodbye.");
            playAgain = false;
        }
        else if(yesNo == "YES")
        {
            Console.WriteLine("Alright");
            Console.Write("Please enter a name: ");
            string name1 = Console.ReadLine();
            name1 = name1.ToUpper();

            Console.WriteLine(" ");
            Console.Write("Enter a color: ");
            string color1 = Console.ReadLine();
            color1 = color1.ToUpper();

            Console.WriteLine(" ");
            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();
            noun1 = noun1.ToUpper();

            Console.WriteLine("");
            Console.Write("Enter an animal: ");
            string animal1 = Console.ReadLine();
            animal1 = animal1.ToUpper();

            Console.WriteLine("");
            Console.Write("Enter another name: ");
            string name2 = Console.ReadLine();
            name2 = name2.ToUpper();
            
            Console.WriteLine("");
            Console.Write("Enter a noun: ");
            string noun2 = Console.ReadLine();
            noun2 = noun2.ToUpper();

            Console.WriteLine("");
            Console.Write("Enter a verb: ");
            string verb1 = Console.ReadLine();
            verb1 = verb1.ToUpper();


        }
}