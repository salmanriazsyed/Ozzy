using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note1Trigger : MonoBehaviour
{
    public AudioSource AudioToPlay;
    public GameObject fence;
    private bool entryFlag;
    // Start is called before the first frame update
    void Start()
    {
        entryFlag = false;
        fence.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (entryFlag == false)
        {
            if (other.CompareTag("Player"))
            {
                entryFlag = true;
                fence.SetActive(false);
                AudioToPlay.Play();
            }
        }
    }
}
