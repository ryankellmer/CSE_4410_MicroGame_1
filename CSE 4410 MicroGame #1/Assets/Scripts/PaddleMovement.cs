using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public bool isPaddle1;
    public float paddleSpeed;
    public Vector3 startPosition;
    public Rigidbody2D rb_paddle;

    private float move;

    // Start position for the paddles.
    void Start()
    {
        startPosition = transform.position;
    }

    // Grabs Inputs from keyboard to move paddle 1 and paddle 2.
    void Update()
    {
        // If true move paddle 1.
        if(isPaddle1)
        {
            move = Input.GetAxisRaw("Vertical1");
        }
        // Else move paddle 2.
        else
        {
            move = Input.GetAxisRaw("Vertical2");
        }

        // The paddle has a rb component and its speed is set from unity.
        rb_paddle.velocity = new Vector2(rb_paddle.velocity.x, move * paddleSpeed);
    }

    // When called paddles return to the starting position.
    public void Reset()
    {
        rb_paddle.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
