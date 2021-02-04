using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody2D rb_ball;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Begin();
    }

    // Update is called once per frame
    public void Reset() 
    {
        rb_ball.velocity = Vector2.zero;
        transform.position = startPosition;
        Begin();

    }

    private void Begin()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb_ball.velocity = new Vector2(ballSpeed * x, ballSpeed * y);
    }
}
