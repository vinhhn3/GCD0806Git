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

    static int Sum(int a, int b, int c)
    {
      return a + b + c;
    }
    static double Sum(double a, double b)
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

    static int Divide(int a, int b)
    {
      return a / b;
    }

    static void FeatureDev02()
    {
      Console.WriteLine("Dummy");
    }
    static void FeatureDev03()
    {
      Console.WriteLine("Dummy");
    }
  }
}
