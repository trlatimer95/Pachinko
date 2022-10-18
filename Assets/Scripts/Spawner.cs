using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;
    [SerializeField]
    private GameObject spawnPos;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        Canvas canvas = GetComponentInChildren<Canvas>();
        if (canvas.worldCamera == null)
            canvas.worldCamera = Camera.main;
    }

    public void SpawnBall()
    {
        if (gameManager.isGameActive && gameManager.ballsAvailable > 0)
        {
            Instantiate(ballPrefab, spawnPos.transform.position, ballPrefab.transform.rotation);
            gameManager.DecrementBall();
        }
    } 
}
