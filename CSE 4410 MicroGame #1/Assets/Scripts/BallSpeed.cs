using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody2D rb_ball;
    public Vector3 startPosition;

    // Ball starts in the center.
    void Start()
    {
        startPosition = transform.position;
        Begin();
    }

    // When called ball position is reset to the start position.
    public void Reset() 
    {
        rb_ball.velocity = Vector2.zero;
        transform.position = startPosition;
        Begin();

    }

    //  Ball either goes downward and right or downward and left.
    private void Begin()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb_ball.velocity = new Vector2(ballSpeed * x, ballSpeed * y);
    }
}
