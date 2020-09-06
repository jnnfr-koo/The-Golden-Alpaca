using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float _maxspeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = CalculateMovement();
    }

    public Vector3 CalculateMovement()
    {
        float verticalMovement = rb.velocity.z;
        float horizontalMovement = rb.velocity.x;

        
        verticalMovement = _maxspeed * Input.GetAxisRaw("Vertical");
        
        horizontalMovement = (_maxspeed * Input.GetAxisRaw("Horizontal"));
        

        return new Vector3(horizontalMovement, 0, verticalMovement);
    }
}
