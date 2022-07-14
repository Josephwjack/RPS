using System;
using System.Collections.Generic;
using RPS.Models;

namespace RPS.Models
{
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("Player one Please choose: rock, paper, scissors");
      string playerOne = Console.ReadLine();
      Game PlayerOne = new Game(playerOne);
      Console.WriteLine("Player two Please choose: rock, paper, scissors");
      string playerTwo = Console.ReadLine();
      Game PlayerTwo = new Game(playerTwo);
      // Draw
      if (PlayerOne.Description == PlayerTwo.Description)
      {
        Console.WriteLine("It is a draw, would you like to play again?(yes/no)");
        string response = Console.ReadLine();
        if (response == "yes")
        {
          Main();
        }
        else {
          Environment.Exit(0);
        }
      }
        // Player One wins with rock
      else if (PlayerOne.Description == "rock" && PlayerTwo.Description == "scissors")
      {
      Console.WriteLine("Player One wins!");
      }
      // Player Two wins with scissors
      else if (PlayerOne.Description == "scissors" && PlayerTwo.Description == "rock")
      {
        Console.WriteLine("Player Two wins!");
      }
    }
  }
}