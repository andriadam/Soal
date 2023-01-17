using System;
public class Program
{
  public static void Main(string[] args)
  {
    int num = 10;

    Console.WriteLine("Soal 1 :");
    for (int i = 1; i <= num; i++)
    {
      for (int j = 1; j <= num - i; j++)
      {
        Console.Write(" ");
      }
      for (int k = 1; k <= (2 * i) - 1; k++)
      {
        if (k % 2 == 0)
          Console.Write(" ");
        else
          Console.Write(i);
      }
      Console.WriteLine();
    }

    Console.WriteLine("\nSoal 2 :");
    for (int i = 1; i <= num; i++)
    {
      for (int j = i; j <= num; j++)
      {
        Console.Write(j);
      }
      Console.WriteLine();
    }
  }

  
}