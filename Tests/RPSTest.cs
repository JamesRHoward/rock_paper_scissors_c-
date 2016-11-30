using Xunit;
using System;
using RPSGame.Objects;
namespace RPSGameTest
{
  public class RulesTest
  {
    [Fact]
    public void Rules_PlayerOneRockPlayerTwoScissorsPOneWins_True()
    {
      string p1Wins = "Player One Wins";
      Rules testRules = new Rules();
      string testWin = testRules.RockPaperScissors("ROCK", "SCISSORS");
      Assert.Equal(p1Wins, testWin);
    }
  }
}
