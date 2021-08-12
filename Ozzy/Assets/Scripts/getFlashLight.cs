using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFlashLight : MonoBehaviour
{
    public bool checkPoint;
    public GameObject meshLight;
    public GameObject lampLight;

    private void Start()
    {
        checkPoint = false;
        lampLight.SetActive(false);
        meshLight.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (checkPoint == false)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Press E to pick flashlight");
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (checkPoint == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                meshLight.SetActive(false);

                lampLight.SetActive(true);
                checkPoint = true;
                Debug.Log("No batteries in the flashlight");
            }
        }
    }
}
