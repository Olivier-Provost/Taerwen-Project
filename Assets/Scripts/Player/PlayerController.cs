using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject {

    public int CurrentHealth = 5;
    public int maxHealth = 5;

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    bool moving;
    bool attacking;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

	private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Slime") && CurrentHealth > 0)
            CurrentHealth -= 1;
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

        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < -0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
        moving = false;
        attacking = false;

        if (move.x != 0 && grounded)
        {
            moving = true;
        }
        if (Input.GetButtonDown("Attack")) {
            attacking = true;
        }

        animator.SetBool("Grounded", grounded);
        animator.SetBool("Moving", moving);
        animator.SetBool("Attack", attacking);

        targetVelocity = move * maxSpeed;
    }
}
