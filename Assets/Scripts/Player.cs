using System.ComponentModel;
using UnityEngine;
using static GamePiece;
using static GameLogic;

public class Player : MonoBehaviour
{
    public GamePiece[] pieces = new GamePiece[4];
    
    public bool DecideAndMovePiece(int rollValue)
    {
        if (rollValue == 6)
        {
            for (int i = 0; i < pieces.Length; i++)
            {
                if (pieces[i].transform.position.x == 0)
                {
                    pieces[i].Move(1);
                    return false;
                }
            }
        }
        else
        {
            for (int i = 0; i < pieces.Length; i++)
            {
                if (pieces[i].transform.position.x + rollValue <= 40)
                {
                    pieces[i].Move(rollValue);
                    return false;
                }
            }
        }
        for (int i = 0; i < pieces.Length; i++)
        {
            if (pieces[i].transform.position.x < 40)
            {
                pieces[i].Move(rollValue);
                return false;
            }
        }
        return true;
    }
}
