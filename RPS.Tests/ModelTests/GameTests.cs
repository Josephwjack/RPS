using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_Game()
    {
      Game newGame = new Game("test");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "rock";
      Game newGame = new Game(description);
      string result = newGame.Description;
      Assert.AreEqual(description, result);
    }
  }
}