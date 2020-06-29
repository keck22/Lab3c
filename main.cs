using System;

class MainClass {
  public static void Main (string[] args) {
    int n, i, m=0, flag=0;
    Console.WriteLine ("Enter a number to see if this number is a prime number");
    n = int.Parse(Console.ReadLine());
    m=n/2
    for (i = 2; i <= m; i++)
    {
      if(n % i == 0)
      {
        Console.WriteLine("The number you entered is not a prime number");
        flag=1;
        break;
      }
    }
    if (flag=0)
    Console.WriteLine("The number you entered is a prime number!");
  }
}
  
//i know this is not complete, I don't understanf why this isnt working, and tried multiple outside sources. Just wanted to show I tried 