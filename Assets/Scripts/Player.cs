using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    /*
     * movement: Holds new input direction from user to move to.
     */
    private Rigidbody rb;
    private PlayerMovement movement;
    private IMovementService movementService;
    private Vector3 newPosition;

    [SerializeField]
    private float maxspeed = 10.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        movement = new PlayerMovement(maxspeed);

        if (movementService == null)
        {
            movementService = new MovementService();
        }
    }

    private void Update()
    {
        // Get player input for new direction, and store it.
        newPosition = new Vector3(
            movementService.GetAxisRaw("Horizontal"),
            0,
            movementService.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        // Call method to add new vector to the speed of the player.
        rb.velocity = movement.CalculateMovement(newPosition);
    }
}
