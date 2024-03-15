// See https://aka.ms/new-console-template for more information
Main(args);
static void Main(string[] args)
{
    int num = 0;
    while(true)
    {
        Console.WriteLine("Välj i menyn (1 - 2)");
        num = int.Parse(Console.ReadLine());
        if (num == 1)
        {
            Greetings();

        }
        else if (num == 2)
            {

            Arvin();
        }
        else
        {
            Console.WriteLine("Goodbye");

        }
    }

}

static void Greetings()
{
    Console.WriteLine("Hello from gitCode");

}

static void Arvin()
{
    Console.WriteLine("Hello from Arvin");

}

