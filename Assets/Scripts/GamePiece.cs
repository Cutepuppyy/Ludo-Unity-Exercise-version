using UnityEngine;
using static GameLogic;
using static Player;

public class GamePiece : MonoBehaviour
{
    private float position = 0;

    public float Position { get => position; }

    public void Move(int x)
    {
        position += x;
        gameObject.transform.position = new Vector3(position,gameObject.transform.position.y,gameObject.transform.position.z);
    }

}