using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickAxe : MonoBehaviour
{
    public GameObject axeMesh;
    public GameObject playerWithAxe;
    private bool checkPoint;
    void Start()
    {
        checkPoint = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (checkPoint == false)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Press E to pick the Axe");
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
                    axeMesh.SetActive(false);
                    playerWithAxe.SetActive(true);
                    checkPoint = true;
                    Debug.Log("Now to break that lock and get in!");
                }
            }
        }
    }
}
