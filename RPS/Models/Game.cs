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
    public void PlayGame()
    {
      if (rock > scissors && rock < paper && rock < atomicBomb || paper > rock && paper < scissors && paper < atomicBomb || scissors > paper && scissors < rock && scissors < atomicBomb)
      {
      Console.WriteLine("you win")
      }
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
