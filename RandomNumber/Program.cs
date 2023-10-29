Random rnd  = new Random();


for (int i = 0; i < 5; i++)
{
    int myRandomNum = rnd.Next(9, 11);
    Console.WriteLine($"My random number is {myRandomNum}");
}