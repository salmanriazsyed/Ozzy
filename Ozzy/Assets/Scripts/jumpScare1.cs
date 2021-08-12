using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScare1 : MonoBehaviour
{
    private bool checkPoint;
    public GameObject objectToAnimate;
    private Animator animationController;
    public AudioSource hitNoise;

    private void Start()
    {
        objectToAnimate.SetActive(false);
        animationController = objectToAnimate.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (checkPoint == false)
        {
            if (animationController.GetBool("isTrigger") == false)
            {
                if (other.CompareTag("Player"))
                {
                    objectToAnimate.SetActive(true);
                    hitNoise.Play();
                    checkPoint = true;
                    animationController.SetBool("isTrigger", true);
                }
            }

        }
    }
}
