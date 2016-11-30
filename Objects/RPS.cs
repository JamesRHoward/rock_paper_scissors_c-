using System;
using System.Collections.Generic;

namespace RPSGame.Objects
{
  public class Rules
  {
    public int playerOne;
    public int playerTwo;
    public static Dictionary<string, int> rps = new Dictionary<string, int> ()
    {
      {"ROCK", 1},
      {"PAPER", 2},
      {"SCISSORS", 3}
    };

    public string RockPaperScissors (string P1Input, string P2Input)
    {
      var P1 = P1Input.ToUpper();
      var P2 = P2Input.ToUpper();

      if (rps.ContainsKey(P1))
      {
        playerOne = rps[P1];
      }
      else
      {
        playerOne = 0;
      }
      if (rps.ContainsKey(P2))
      {
        playerTwo = rps[P2];
      }
      else
      {
        playerTwo = 0;
      }

      if (playerOne == 0 || playerTwo == 0)
      {
        return "Invalid Choice!";
      }
      else if (playerOne == playerTwo)
      {
        return "Draw";
      }
      else if (playerTwo > playerOne && (playerOne - playerTwo) == 2) //P1: Rock(1) P2: Scissors(3)
      {
        return "Player Two Wins";
      }
      else if (playerOne > playerTwo && (playerOne - playerTwo) == 2) //P2: Rock(1) P1: Scissors(3)
      {
        return "Player Two Wins";
      }
      else if (playerOne > playerTwo && (playerOne - playerTwo) == 1)
      {
        return "Player One Wins";
      }
      else if (playerTwo > playerOne && (playerOne - playerTwo) == 1)
      {
        return "Player Two Wins";
      }
      else
      {
        return "Try again!";
      }
    }
  }
}
