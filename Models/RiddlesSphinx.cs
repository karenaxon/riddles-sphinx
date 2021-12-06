using System;

namespace Challenge.Models
{
  public class RiddlesSphinx
  {
    public string Riddle { get; set; }
    public string Answer { get; set; }

    // Constructor
    public RiddlesSphinx(string riddle, string answer)
    {
      Riddle = riddle;
      Answer = answer;
    }
  }
}