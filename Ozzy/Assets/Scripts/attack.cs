using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Animator axeAnimator;
    public static bool isPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!isPaused)
            {
                axeAnimator.SetTrigger("isAttack");
            }
        }
    }
}
