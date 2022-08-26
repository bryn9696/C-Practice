using System.Text.RegularExpressions;
using System;
namespace String
{
  class Program
  {
    static void Main(string[] args)
      {
        int num = 4;
        num++;

        int x = 4;
        x--;

        Console.WriteLine( num );
        Console.WriteLine( x );
        Console.WriteLine( Math.Pow(4, 2) );
        Console.WriteLine( Math.Sqrt(64) );
        Console.WriteLine( Math.Max(4, 20) );
        Console.WriteLine( Math.Round(4.69) );
      }
  }
}