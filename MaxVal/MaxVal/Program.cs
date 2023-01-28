using System.Reflection.Metadata.Ecma335;

class MaxVal
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        while (num >= 1|| num <=100)
        {
            Console.WriteLine("Invalid number!");  
            num=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The числото is: {0}",num); 
    }
}
