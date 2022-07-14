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
        // Player One wins
      else if (PlayerOne.Description == "rock" && PlayerTwo.Description == "scissors" || PlayerOne.Description == "paper" && PlayerTwo.Description == "rock" || PlayerOne.Description == "scissors" && PlayerTwo.Description == "paper")
      {
        Console.WriteLine("Player One Wins! Would you like to play again?(yes/no)");
        string response = Console.ReadLine();
        if (response == "yes")
        {
          Main();
        }
        else {
          Environment.Exit(0);
        }
      }
      // Player Two wins
      else if (PlayerOne.Description == "scissors" && PlayerTwo.Description == "rock" || PlayerOne.Description == "rock" && PlayerTwo.Description == "paper" || PlayerOne.Description == "paper" && PlayerTwo.Description == "scissors")
      {
        Console.WriteLine("Player Two wins! Would you like to play again?(yes/no)");
        string response = Console.ReadLine();
        if (response == "yes")
        {
          Main();
        }
        else {
          Environment.Exit(0);
        }
      }
    }
  }
}