using System;

namespace GCD0806Git
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int a = 10;
      int b = 20;
      int sum = Sum(a, b);
      Console.WriteLine(sum);
    }

    static int Sum(int a, int b)
    {
      return a + b;
    }

    static int Substract(int a, int b)
    {
      return a - b;
    }

    static int Multiply(int a, int b)
    {
      return a * b;
    }
  }
}
