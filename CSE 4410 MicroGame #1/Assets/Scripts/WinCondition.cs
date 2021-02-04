using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPaddle1Win;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            if(!isPaddle1Win)
            {
                Debug.Log("Paddle 1 Scored A Point!!!");
                GameObject.Find("GameManager").GetComponent<GameManager>().Paddle1Point();
            }
            else
            {
                Debug.Log("Paddle 2 Scored A Point!!!");
                GameObject.Find("GameManager").GetComponent<GameManager>().Paddle2Point();
            }
        }

    }
}
