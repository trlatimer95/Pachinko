using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentScore;

    void Start()
    {
        currentScore = 0;
    }

    public void AddPoints(int points)
    {
        currentScore += points;
    }
}
