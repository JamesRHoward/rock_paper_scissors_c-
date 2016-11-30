## Specs


| Behavior - Plain english             | input                 | output  |
|--------------------------------------|-----------------------|---------|
| If both players choose same move     | P1: Rock P2: Rock     | Draw    |
| P1 chooses Rock P2 Chooses Paper     | P1: Rock P2: Paper    | P2 Wins |
| P1 Chooses Scissors P2 Chooses Paper | P1: Scissor P2: Paper | P1 Wins |
| P1 Chooses Rock P2 Chooses Scissors  | P1: Rock P2: Scissors | P1 Wins |






p1: scissors(3) p2: rock(1) compare p1(3) - p2 (1) if its = 2 player two wins
p1: scissors(3) p2: paper(2) compare p1(3) - p2 (2) if its = 1 player one wins
p1:rock(1) p2: scissors(3) compare p1(1) - p2 (3) if its = 1 player two wins

p1:Scissors(3) p2:Paper(2) compare p1(3) - p2(2) if its = 1 player one wins\

p1:Paper(2) p2:Rock(1) compare p1(2) - p2(1) if its == 1 player one wins
(playerOne > playerTwo && (playerOne - playerTwo) == 2
{
  return "player two wins"
}
