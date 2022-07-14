using System;

namespace RPS.Models
{
  public class Game
  {
    public string Description { get; set; }
    // constructor
    public Game(string description)
    {
      Description = description;
    }
  }
}

// rock > scissors
// rock < paper
// paper > rock
// paper < scissors
// scissors > paper
// scissors < rock
// atomic bomb > rock && scissors && paper
