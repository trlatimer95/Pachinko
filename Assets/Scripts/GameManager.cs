using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int currentScore;
    public int ballsAvailable = 10;

    public bool isGameActive = false;

    [Header("UI")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ballsText;
    public GameObject gameUI;
    public GameObject gameOverMenu;
    public TextMeshProUGUI finalScoreText;
    public GameObject mainMenu;

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
                finalScoreText.text = "Final Score: " + currentScore;
                gameUI.SetActive(false);
                gameOverMenu.SetActive(true);
            }
        }
    }

    public void StartGame()
    {
        currentScore = 0;
        AddPoints(0);
        ballsText.text = "Balls: " + ballsAvailable;
        mainMenu.SetActive(false);
        gameUI.SetActive(true);
        isGameActive = true;

        StartCoroutine(CheckWinCondition());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        StartGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
