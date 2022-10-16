using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    public int pointLimit = 10;
    public int points;

    void Start()
    {
        points = Random.Range(-pointLimit, pointLimit);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
