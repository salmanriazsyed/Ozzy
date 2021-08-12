using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakLock : MonoBehaviour
{
    public bool checkPoint;
    public GameObject ghostWoman;
    public GameObject lockCube;
    public GameObject door;
    public AudioSource computerRoomSong;
    public AudioSource playerSong;
    public AudioSource stressSong;
    public AudioSource lockBreakSound;
    private Animator animator;
    private Rigidbody rb;


    void Start()
    {
        checkPoint = false;
        animator = lockCube.GetComponent<Animator>();
        rb = door.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (checkPoint == false)
        {
            if (other.CompareTag("AxeHead"))
            {
                checkPoint = true;
                ghostWoman.SetActive(false);
                playerSong.Stop();
                stressSong.Stop();
                lockBreakSound.Play();
                computerRoomSong.Play();
                animator.SetBool("drop",true);
                rb.isKinematic = false;
            }
        }
    }
}