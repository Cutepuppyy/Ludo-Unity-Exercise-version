using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


public class GameLogic : MonoBehaviour
{
    public void PlayGame()
    {
        Player[] players = new Player[4];
        for (int i = 0; i < players.Length; i++)
        {
            players[i] = new Player();
        }
        int winnerFound = -1;
        while (winnerFound < 0)
        {
            for (int i = 0; i < players.Length; i++)
            {
                int diceRoll = RollDice();
                bool winner = players[i].DecideAndMovePiece(diceRoll);
                if (winner)
                {
                    winnerFound = i;
                    break;
                }
                WaitForSeconds025();
            }
        }
        Console.WriteLine("winner is player " + winnerFound);

        int RollDice()
        {
            int diceRoll = UnityEngine.Random.Range(1, 7); // Random number between 1 and 6
            Debug.Log("You rolled a " + diceRoll);
            return diceRoll;
        }
    }
    private void Start()
    {
        StartCoroutine(WaitForSeconds025());
        PlayGame();
    }

    IEnumerator WaitForSeconds025()
    {
        yield return new WaitForSeconds(0.2f);
    }
}

