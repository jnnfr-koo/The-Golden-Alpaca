using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    const float _maxspeed = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        rb.velocity = MovementDiretion(rb.velocity.z, rb.velocity.x);
    }

    Vector3 MovementDiretion(float verticalMovement, float horizontalMovement)
    {
        if (Input.GetAxisRaw("Vertical") != 0.0f)
        {
            verticalMovement = (_maxspeed * Input.GetAxisRaw("Vertical"));
        }
        else
        {
            verticalMovement = 0.0f;
        }

        if (Input.GetAxisRaw("Horizontal") != 0.0f)
        {
            horizontalMovement = (_maxspeed * Input.GetAxisRaw("Horizontal"));
        }
        else
        {
            horizontalMovement = 0.0f;
        }

        return new Vector3(horizontalMovement, 0, verticalMovement);
    }
}
