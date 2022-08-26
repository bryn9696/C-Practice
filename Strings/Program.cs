using System;
namespace String
{
  class Program
  {
    static void Main(string[] args)
      {
        Console.WriteLine("Hello, \nBryn");
        Console.WriteLine("Hello, \nBryn" + " is cool");
        string phrase = "Brynnnnn";
        Console.WriteLine( phrase );
        Console.WriteLine( phrase.Length );
        Console.WriteLine( phrase.ToUpper() );
        Console.WriteLine( phrase.Contains("Bryn") );
        Console.WriteLine( phrase[2] );
        Console.WriteLine( phrase.IndexOf('r') );
        Console.WriteLine( phrase.Substring(3) );
      }
  }
}