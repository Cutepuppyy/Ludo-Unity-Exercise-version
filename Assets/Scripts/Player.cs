using System.ComponentModel;
using UnityEngine;
using static GamePiece;
using static GameLogic;

public class Player : MonoBehaviour
{
    //Inputting variables the pæayer should have
    public int[] TurnOrder = new int[4];
    public int PiecesHome = 4;
    public int PiecesMoving = 0;
    public int PiecesGoal = 0;
    public GamePiece[] Pieces = new GamePiece[4];
    // A Constructor for the player
    public Player()
    {
        //Creating the pieces when the players are made
        for (int PieceNumber = 0; PieceNumber < Pieces.Length; PieceNumber++)
        {
            Pieces[PieceNumber] = new GamePiece();
        }
    }
}
