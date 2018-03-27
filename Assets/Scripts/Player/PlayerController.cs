using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject {

    public int CurrentHealth = 3;
    public int maxHealth = 5;

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    private void Start()
    {

    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Move");

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y *= 0.5f;
            }
        }
        targetVelocity = move * maxSpeed;
    }
}
