using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class WinCondition : MonoBehaviour
{
    public bool isPaddle1Win;

    // Determine which player gets the point.
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        // If the ball touches the left or right wall a point will be assigned.
        if(collision.gameObject.CompareTag("Ball"))
        {
            // If player 1 is true then the point goes to player 1.
            if(isPaddle1Win)
            {
                Debug.Log("Paddle 1 Scored A Point!!!");
                GameObject.Find("GameManager").GetComponent<GameManager>().Paddle1Point();
            }
            // Else player 2 gets the point.
            else
            {
                Debug.Log("Paddle 2 Scored A Point!!!");
                GameObject.Find("GameManager").GetComponent<GameManager>().Paddle2Point();
            }
        }
    }
}
