using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goGetAxe : MonoBehaviour
{
    public AudioSource heavyKnock;
    private bool hasKnocked = false;
    public GameObject room1Corridor;
    public GameObject playerWithAxe;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!playerWithAxe.activeSelf)
            {
                Debug.Log("Need to find the lock's key or something to break it with");
            }
            else
            {
                Debug.Log("Break the lock!");
            }
        
            if (!hasKnocked)
            {
                hasKnocked = true;
                room1Corridor.SetActive(false);
                heavyKnock.Play();
            }
        }
    }

    private void Start()
    {
        hasKnocked = false;
        room1Corridor.SetActive(true);
    }
}
