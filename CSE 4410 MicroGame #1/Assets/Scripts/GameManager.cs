using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Create all the game objects.
    [Header("Ball")]
    public GameObject ball;

    [Header("Paddle 1")]
    public GameObject Paddle1;
    public GameObject rightWall;

    [Header("Paddle 2")]
    public GameObject Paddle2;
    public GameObject leftWall;

    [Header("Score")]
    public GameObject Paddle1ScoreText;
    public GameObject Paddle2ScoreText;

    private int Paddle1Score;
    private int Paddle2Score;

    void Update() 
    {
        // Player 1 wins if they reach 9 points first.
        if(Paddle1Score >= 9)
        {
             Debug.Log("Player 1 Wins!!!");
            //Time.timeScale = 0;
            //enabled = false;
            SceneManager.LoadScene("Player1Win");
        }
        // Player 2 wins if they reach 9 points first.
        if(Paddle2Score >= 9)
        {
            Debug.Log("Player 2 Wins!!!");
            //Time.timeScale = 0;
            //enabled = false;
            SceneManager.LoadScene("Player2Win");
        }
    }

    //  Then number is increased by 1 and updated to the scoreboard for Player 1. Then the ball and paddle are reset.
    public void Paddle1Point()
    {
        Paddle1Score++;
        Paddle1ScoreText.GetComponent<TextMeshProUGUI>().text = Paddle1Score.ToString();
        ResetPosition();
    }

    //  Then number is increased by 1 and updated to the scoreboard for Player 2. Then the ball and paddle are reset.
    public void Paddle2Point()
    {
        Paddle2Score++;
        Paddle2ScoreText.GetComponent<TextMeshProUGUI>().text = Paddle2Score.ToString();
        ResetPosition();
    }

    // Paddle 1, Paddle 2, and the Ball are all set to the starting position.
    private void ResetPosition()
    {
        ball.GetComponent<BallSpeed>().Reset();
        Paddle1.GetComponent<PaddleMovement>().Reset();
        Paddle2.GetComponent<PaddleMovement>().Reset();
    }

}
