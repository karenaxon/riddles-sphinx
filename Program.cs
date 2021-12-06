using System;
using System.Collections.Generic;
using Challenge.Models;

namespace Challenge {

  public class Program 
  {
    public static void Main()
    {
      RiddlesSphinx riddle1 = new RiddlesSphinx("The more you code, the more of me there is. I may be gone for now but you can’t get rid of me forever. What am I?",  "a bug");

      RiddlesSphinx riddle2 = new RiddlesSphinx("As a developer I’m your eyes, showing you the result of your code in your language of choice. What am I?", "a print statement");

      RiddlesSphinx riddle3 = new RiddlesSphinx("As a developer, you usually get mad at me because I complain a lot, although I’m usually right. What am I?", "a compiler");

      RiddlesSphinx riddle4 = new RiddlesSphinx("I’m a language for everything yet I have no real identity of my own. Good luck trying to compile me. What am I?", "pseudocode");

      RiddlesSphinx riddle5 = new RiddlesSphinx("I’m a simple thing, nothing special. While I have many cousins we’re all very similar because we set your project up. What am I?", "a configuration file");

      List<RiddlesSphinx> RiddlesList = new List<RiddlesSphinx>(){riddle1, riddle2, riddle3, riddle4, riddle5};

      Random randomRiddle = new Random();

      int index = randomRiddle.Next(RiddlesList.Count);
      Console.WriteLine(RiddlesList[index].Riddle);
      Console.WriteLine("Finish my riddle.");
      string input = Console.ReadLine().ToLower();
      if (RiddlesList[index].Answer == input)
      {
        Console.WriteLine("You got it!");
      }
      else 
      {
        Console.WriteLine("Sorry! That's not the correct answer. Would you like to try again? Enter 'Y' for yes, 'Enter' to quit.");
        string finishedAnswer = Console.ReadLine();
        if (finishedAnswer == "y" || finishedAnswer == "Y")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Goodbye.");
        }
      }
    }
  }
}