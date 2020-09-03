using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public float Speed;

    public PlayerMovement(float speed)
    {
        Speed = speed;
    }

    public Vector3 CalculateMovement(float verticalMovement, float horizontalMovement)
    {
        float x = verticalMovement * Speed;
        float z = horizontalMovement * Speed;

        return new Vector3(horizontalMovement, 0, verticalMovement);
    }
}
