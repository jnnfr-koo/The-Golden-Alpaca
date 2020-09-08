using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    /*
     * movement: Holds new input direction from user to move to.
     */
    public Rigidbody rb;
    public float maxspeed = 10.0f;
    public Vector3 movement;

    public Move moveTest;

    private IMovementService movementService;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveTest = new Move(maxspeed);

        if (movementService == null)
        {
            movementService = new MovementService();
        }
    }

    private void Update()
    {
        // Get player input for new direction, and store it.
        movement = new Vector3(
            movementService.GetAxisRaw("Horizontal"),
            0,
            movementService.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        // Call method to add new vector to the speed of the player.
        rb.velocity = moveTest.CalculateMovement(movement);
    }
}
