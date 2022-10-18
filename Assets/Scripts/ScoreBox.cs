using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBox : MonoBehaviour
{
    public int pointLimit = 10;
    public int points;
    public AudioClip scoreClip;
    public TextMeshProUGUI pointText;

    private GameManager gameManager;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        points = Random.Range(1, pointLimit + 1);
        pointText.text = points.ToString();

        Canvas canvas = GetComponentInChildren<Canvas>();
        if (canvas.worldCamera == null)
            canvas.worldCamera = Camera.main;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            gameManager.AddPoints(points);
            Destroy(other.gameObject, 1);
            audioSource.PlayOneShot(scoreClip);
        }
    }
}
