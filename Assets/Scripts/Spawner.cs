using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;
    [SerializeField]
    private GameObject spawnPos;

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        Instantiate(ballPrefab, spawnPos.transform.position, ballPrefab.transform.rotation);
    }
}
