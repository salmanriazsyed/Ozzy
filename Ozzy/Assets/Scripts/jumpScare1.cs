using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpScare1 : MonoBehaviour
{
    private bool checkPoint;
    public GameObject objectToAnimate;
    private Animator animationController;
    public AudioSource hitNoise;
    public GameObject textBox;
    private Text txt;

    private void Start()
    {
        objectToAnimate.SetActive(false);
        animationController = objectToAnimate.GetComponent<Animator>();
        txt = textBox.GetComponent<Text>();
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
                    txt.text = "F**k!";
                }
            }

        }
    }
}
