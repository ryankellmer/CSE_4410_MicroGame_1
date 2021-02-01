using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public bool isPaddle1;
    public float paddleSpeed;
    public Rigidbody2D rb_paddle;
    private float move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPaddle1)
        {
            move = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            move = Input.GetAxisRaw("Vertical2");
        }

        rb_paddle.velocity = new Vector2(rb_paddle.velocity.x, move * paddleSpeed);
    }
}
