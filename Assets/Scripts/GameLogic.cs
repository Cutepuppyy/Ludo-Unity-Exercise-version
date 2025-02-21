using System.Collections;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
        
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