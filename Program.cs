using System;
using System.Collections.Generic;
using PingPong;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number");
      string stringNumber = Console.ReadLine();
      int number = int.Parse(stringNumber);
      
      List<int> NumberList = new List<int>(){};
      for (int i = 1; i <= number; i++)
      {
        NumberList.Add(i);
      }
      for (int i = 0; i <= number - 1; i++) 
      {
        if (NumberList[i] % 3 == 0 && NumberList[i] % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        else if (NumberList[i] % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (NumberList[i] % 5 == 0)
        {
          Console.WriteLine("pong");
        } 
        else 
        {
        Console.WriteLine(NumberList[i]);
        }
      }
    }
  }
}