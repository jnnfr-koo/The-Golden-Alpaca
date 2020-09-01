using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerMovement movementControls;

    void Start()
    {
        movementControls = new PlayerMovement();
    }

    void Update()
    {
        
    }
}
