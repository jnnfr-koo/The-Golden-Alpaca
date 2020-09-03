using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MaxSpeed;
    public PlayerMovement Movement;

    void Start()
    {
        Movement = new PlayerMovement(MaxSpeed);
    }

    void Update()
    {
        transform.position += Movement.CalculateMovement(
            Input.GetAxisRaw("Vertical"),
            Input.GetAxisRaw("Horizontal"),
            Time.deltaTime);
    }


}
