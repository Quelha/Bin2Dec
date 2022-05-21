using System;

public class Conversion
{
  public static void Main(string[] args)
  {
    int number, i;
    int[] Binary = new int[100];
    Console.Write("Digite um numero Decimal:");
    number = int.Parse(Console.ReadLine());
    //Console.Write(number);

    for (i = 0; number > 0; i++)
    {
      Binary[i] = number % 2;
      number /= 2;
      //Console.Write(Binary[i]);
      //Console.Write(number);
    }

    for (i = i - 1; i >= 0; i--)
    {
      Console.Write(Binary[i]);
    }
  }
}