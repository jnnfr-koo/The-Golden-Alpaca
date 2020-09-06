using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to control player movement throughout levels.
 */
public class PlayerMovement : MonoBehaviour
{
    /*
     * movement: Holds new input direction from user to move to.
     */
    public Rigidbody rb;
    public float maxspeed;
    public Vector3 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get player input for new direction, and store it.
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        // Call method to add new vector to the speed of the player.
        rb.velocity = CalculateMovement(movement);
    }

    public Vector3 CalculateMovement(Vector3 direction)
    {   
        return direction * maxspeed;
    }
}
