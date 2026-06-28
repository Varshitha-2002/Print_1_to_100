using System;
class printOneToHundered
{
    public static void Main(String[] args)
    {

        for (int i = 0; i <= 100; i+=4)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even");
            } 
            Console.WriteLine($"{i} is odd");   

        }
    }
    
}
          

      