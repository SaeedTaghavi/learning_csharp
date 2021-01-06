using System;
class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    myObj.set_color("blue");
    Console.WriteLine(myObj.color);
  }
}