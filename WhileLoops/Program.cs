
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while(loopActive)
{
    cpuRandom = rnd.Next(1, 10);
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-9");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Wohooo, you won!");
        //loopActive = false;
        break;
        //Saab olla break; või loopActive = false;

    }
    else
    {
        Console.WriteLine("No no no. Try again.");
    }

}

Console.WriteLine("Have a nice day, ciao!");
