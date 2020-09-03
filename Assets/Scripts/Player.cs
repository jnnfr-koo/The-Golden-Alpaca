using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed;
    public PlayerMovement movement;

    public Rigidbody rb;

    void Start()
    {
        movement = new PlayerMovement(maxSpeed);
        rb = GetComponent<Rigidbody>();
    PlayerMovement movementControls;

    void Start()
    {
        movementControls = new PlayerMovement();
    }

    void Update()
    {
        rb.velocity = movement.CalculateMovement(
            Input.GetAxisRaw("Vertical"),
            Input.GetAxisRaw("Horizontal"));
    }


}
