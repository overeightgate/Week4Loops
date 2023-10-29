
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;
while (loopActive)
{ 
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. Enter number 1- 3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom) 
    {
        Console.WriteLine("You won!");
        loopActive = false;
    } 
    else 
    {
        Console.WriteLine("Oops. Try agin.");
    }

}