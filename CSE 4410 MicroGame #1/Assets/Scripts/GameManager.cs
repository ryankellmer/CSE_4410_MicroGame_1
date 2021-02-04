using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
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

    public void Paddle1Point()
    {
        Paddle1Score++;
        Paddle1ScoreText.GetComponent<TextMeshProUGUI>().text = Paddle1Score.ToString();
        ResetPosition();
    }

    public void Paddle2Point()
    {
        Paddle2Score++;
        Paddle2ScoreText.GetComponent<TextMeshProUGUI>().text = Paddle2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<BallSpeed>().Reset();
        Paddle1.GetComponent<PaddleMovement>().Reset();
        Paddle2.GetComponent<PaddleMovement>().Reset();
    }
}
