using UnityEngine;
using static GameLogic;
using static Player;

public class GamePiece : MonoBehaviour
{
    //Making the variables the piece uses
    public int SpacesMoved = 0;
    public bool Home = true;
    public bool Moving = false;
    public bool Goal = false;
    //A Constructor for the Piece
    public GamePiece()
    { }
    public int SpacesMoving(int SpacesToMove)
    {
        return SpacesMoved = SpacesMoved + SpacesToMove;
    }

}
