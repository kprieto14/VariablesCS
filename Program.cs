using System;

namespace VariablesCS
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaring # of cups of coffee I drink per day
      var numberOfCupsOfCoffee = 0;
      // Declaring my full name
      var fullName = "Kristy Prieto";
      
      // Declaring the variables needed to get the day of the week 
      DateTime now = DateTime.Now;
      DayOfWeek today = now.DayOfWeek;

      Console.WriteLine($"Hello, my name is {fullName}. Today is {today}, and I have drunk {numberOfCupsOfCoffee} cups of coffee today.");
      
      //Asks user what their name is and greets them back.
      Console.Write("What is your name? ");
      var name = Console.ReadLine();
      Console.WriteLine($"It is a pleasure to meet you, {name}! :)");

      //Asks user to enter 2 numbers and store them as strings, then converts them to doubles
      Console.Write("Please enter your first number: ");
      string firstNumberAsString = Console.ReadLine();
      double firstOperand = double.Parse(firstNumberAsString);

      Console.Write("Please enter your second number: ");
      string secondNumberAsString = Console.ReadLine();
      double secondOperand = double.Parse(secondNumberAsString);

      // A variety of math operations stored in their corresponding variables, then tells the user some math answers
      var sum = firstOperand + secondOperand; 
      var difference = secondOperand - firstOperand;
      var product = firstOperand * secondOperand;
      var quotient = firstOperand / secondOperand;
      var remainder = firstOperand % secondOperand;
      Console.WriteLine($"Fun facts! If you add {firstNumberAsString} and {secondNumberAsString}, you get {sum}. Isn't that neat?");
      Console.WriteLine($"What about subtracting {secondNumberAsString} and {firstNumberAsString}? More fun facts, you get {difference}!");
      Console.WriteLine($"The fun doesn't stop there, what do you get if you multiply {firstNumberAsString} with {secondNumberAsString}? That's right, you get {product}!");
      Console.WriteLine($"Why stop there? Lets divide {firstNumberAsString} by {secondNumberAsString}. If you guessed {quotient}, you're right!");
      Console.WriteLine($"And to top it all off, what is the remainder when you divide {firstNumberAsString} by {secondNumberAsString}? That's right, it's {remainder}!");
    }
  }
}
