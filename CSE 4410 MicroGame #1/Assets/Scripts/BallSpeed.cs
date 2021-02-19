using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BallSpeed : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody2D rb_ball;
    public Vector3 startPosition;
    public AudioSource bounce;

        // Ball starts in the center.
        public void Start()
    {
        bounce = GetComponent<AudioSource> ();
        startPosition = transform.position;
        Invoke("Begin", 1.0f);
    }

    public void  OnCollisionEnter2D(Collision2D collision2D) 
    {
        bounce.Play();
    }

    // When called ball position is reset to the start position.
    public void Reset() 
    {
        rb_ball.velocity = Vector2.zero;
        transform.position = startPosition;
        Invoke("Begin", 1.0f);
    }

    //  Ball either goes downward and right or downward and left.
    private void Begin()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb_ball.velocity = new Vector2(ballSpeed * x, ballSpeed * y);
    }
}
