using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public AudioSource carAudio;
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (myAnimationController.GetBool("isCol") == false)
        {
            if (other.CompareTag("Player"))
            {
                myAnimationController.SetBool("isCol", true);
                carAudio.Play();
            }
        }
    }
}
