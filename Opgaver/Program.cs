
/*class Program
{

    static void Main()
    {
        
        string str= HelloWorld();
       Console.WriteLine (str);

    }

    static string HelloWorld()
    {
        
        return "mr. poopy butthole";
    }

}
*/


int sum(int x)
{
    if (x >= 10)
    {
        return 10;
    }
    Console.WriteLine($"{x}");
    if (x <= 9)
    {
        return sum(x + 1);
    }
    return x;
}

void start()
{
    Console.WriteLine(sum(1));
}

start();