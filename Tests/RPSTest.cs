using Xunit;
using System;
using RPSGame.Objects;
using System.Collections.Generic;
namespace RPSGameTest
{
  public class RulesTest
  {
    [Fact]
    public void Rules_PlayerOneRockPlayerTwoScissorsPOneWins_True()
    {
      string p1Wins = "Player One Wins";
      Rules testRules = new Rules();
      string testWin = testRules.RockPaperScissors("rock", "scissors");
      Assert.Equal(p1Wins, testWin);
    }
    [Fact]
    public void Rules_PlayerOneEqualsZeroPlayerTwoEqualsZero_True()
    {
      string p1Wins = "Invalid Choice!";
      Rules testRules = new Rules();
      string testWin = testRules.RockPaperScissors("", "");
      Console.WriteLine("Test" + testWin);
      Assert.Equal(p1Wins, testWin);
    }
  }
}
