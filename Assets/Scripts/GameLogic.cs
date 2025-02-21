using System.Collections;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


public class GameLogic : MonoBehaviour
{
    void OpretSpillere()
    {
        Player[] players = new Player[4];
        for (int i = 0; i < players.Length; i++)
        {
            players[i] = new Player();
        }
    }
    private void Start()
    {
        OpretSpillere();
        int winnerFound = -1;
    }
}
//Making a dice
public class DiceRoller
{

    void RollDice()
    {
        int diceRoll = Random.Range(1, 7); // Random number between 1 and 6
        Debug.Log("You rolled a " + diceRoll);
    }
}

