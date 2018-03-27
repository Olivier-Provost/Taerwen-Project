using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {

    Rigidbody2D rb;
    Vector2 forceToAdd;
    public float maxSpeed;
    public float playerSpeed = 1f;
    public int CurrentHealth = 3;
    public int maxHealth = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        forceToAdd = new Vector2();
    }

    private void FixedUpdate()
    {
        //rb.AddForce(forceToAdd);
        rb.position += forceToAdd;
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
        Debug.Log(forceToAdd);
        forceToAdd = new Vector2();
    }

    public void MovePressed(float moveDirection)
    {
        forceToAdd += Vector2.right * moveDirection * playerSpeed;
        //Debug.Log("Move Pressed : " + moveDirection);
    }

    public void JumpPressed(float jumpForce)
    {

        forceToAdd += Vector2.up * jumpForce * playerSpeed;
    }

}
