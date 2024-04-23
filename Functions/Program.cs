using System.Threading.Channels;

Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();
if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}







static void PrintHello() //functions / method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodbye() 
{
    Console.WriteLine("See you later, aligator.");
}

