using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the number you would like to volley to:");
    int number = int.Parse(Console.ReadLine());
    
    int[] volley = new int[number];
    for (int i = 0 ; i < volley.Length; i++)
    {
      volley[i] = i+1;
      if (volley[i]%3 == 0 && volley[i]%5 == 0)
      {
        Console.WriteLine("ping-pong");

      }
      else if (volley[i]%5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (volley[i]%3 == 0)
      {
        Console.WriteLine("ping");
      }
      else
      {
        Console.WriteLine(volley[i]);
      }
    }
  }
}


