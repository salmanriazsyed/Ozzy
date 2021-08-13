using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathOfFinalEnemy : MonoBehaviour
{
    public GameObject wall;
    private Animator wallAnimator;
    public GameObject direcLight;
    public GameObject theEnd;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AxeHead"))
        {
            this.gameObject.SetActive(false);
            wallAnimator.SetTrigger("move");
            direcLight.SetActive(true);
            theEnd.SetActive(true);
        }
    }

    private void Start()
    {
        theEnd.SetActive(false);
        direcLight.SetActive(false);
        wallAnimator = wall.GetComponent<Animator>();
    }
}
