using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public List<AudioClip> bounceSounds;

    private AudioClip bounceClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        bounceClip = bounceSounds[Random.Range(0, bounceSounds.Count)];
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision entered");
        if (collision.gameObject.CompareTag("Ball"))
        {
            audioSource.PlayOneShot(bounceClip);
        }
    }
}
