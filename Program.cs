// Richard Johnson
// 10-18-22
//

bool playAgain = true;

// This while loop will continue running as long as playAgain is true
while(playAgain == true)
{
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
            string name = Console.ReadLine();
            name = name.ToUpper();
        }
}