using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBattery : MonoBehaviour
{
    public bool checkPoint;
    public GameObject flashLight;
    public GameObject batteries;
    public GameObject zombie;
    public GameObject corridorToHide;

    void Start()
    {
        flashLight.SetActive(false);
        checkPoint = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (checkPoint == false)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Press E to put batteries in the flashlight");
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (checkPoint == false)
        {
            if (other.CompareTag("Player"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    corridorToHide.SetActive(false);
                    flashLight.SetActive(true);
                    batteries.SetActive(false);
                    zombie.SetActive(false);
                    checkPoint = true;
                    Debug.Log("Press F to toggle Flashlight");
                }
            }
        }


    }





}
