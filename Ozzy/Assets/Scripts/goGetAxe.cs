using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goGetAxe : MonoBehaviour
{
    public bool checkPoint;
    public GameObject axeLight;
    public GameObject axeTriggerCube;

    private void Start()
    {
        checkPoint = false;
        axeLight.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (checkPoint == false)
        {
            if (other.CompareTag("Player"))
            {
                checkPoint = true;
                axeTriggerCube.SetActive(true);
                axeLight.SetActive(true);
                Debug.Log("Need something to break the lock!");
            }
        }
    }
}
