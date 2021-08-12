using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Animator axeAnimator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            axeAnimator.SetTrigger("isAttack");
        }
    }
}
