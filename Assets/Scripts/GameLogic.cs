using System.Collections;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
        
}
//Making a dice
        public class Dice
        {
            Random dice;
            public Dice()
            {
                dice = new Random();
            }
            //The function to roll the dice
            public int DiceSpacesToMove()
            {
                return dice.Next(1,7);
            }
        }