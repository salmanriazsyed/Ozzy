using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnGhostWoman : MonoBehaviour
{
    public GameObject ghostWoman;

    private void Start()
    {
        ghostWoman.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ghostWoman.SetActive(true);
        }
    }
}
