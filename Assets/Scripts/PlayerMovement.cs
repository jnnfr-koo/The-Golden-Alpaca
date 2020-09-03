using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
<<<<<<< HEAD
    public float Speed;
=======

>>>>>>> parent of 86c8d2d... Update Movement to Method

    public PlayerMovement(float speed)
    {
        Speed = speed;
    }

    public Vector3 CalculateMovement(float verticalMovement, float horizontalMovement)
    {
<<<<<<< HEAD
        float x = verticalMovement * Speed;
        float z = horizontalMovement * Speed;
=======
>>>>>>> parent of 86c8d2d... Update Movement to Method

        return new Vector3(horizontalMovement, 0, verticalMovement);
        rb.velocity = new Vector3(horizontalMovement, 0, verticalMovement);
    }
}
