using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int currentScore;
    public int ballsAvailable = 10;

    public bool isGameActive = true;

    [Header("UI")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ballsText;

    void Start()
    {
        currentScore = 0;
        AddPoints(0);
        ballsText.text = "Balls: " + ballsAvailable;

        StartCoroutine(CheckWinCondition());
    }

    public void AddPoints(int points)
    {
        currentScore += points;
        scoreText.text = "Score: " + currentScore;
    }

    public void DecrementBall()
    {
        ballsAvailable--;
        ballsText.text = "Balls: " + ballsAvailable;
    }

    IEnumerator CheckWinCondition()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(1);
            if (ballsAvailable < 1 && GameObject.FindGameObjectsWithTag("Ball").Length < 1)
            {
                isGameActive = false;
                Debug.Log("Round over");
            }
        }
    }
}
