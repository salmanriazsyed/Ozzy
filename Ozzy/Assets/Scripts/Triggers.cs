using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Triggers : MonoBehaviour
{
    public AudioSource mainSong;
    public AudioSource stress;
    public AudioSource relief;

    //ghostWoman
    public GameObject ghostWoman;
    private NavMeshAgent ghostNMAgent;

    //All Notes:
    public GameObject noteLight;
    public GameObject Note1;
    public GameObject Note2;
    public GameObject Note3;
    public GameObject Note4;
    public GameObject Note5;
    public GameObject Note6;
    public GameObject Note7;


    //get flashlight trigger:
    private bool isFlashCollected;
    public GameObject meshLight;
    public GameObject stairDownOpen;
    public AudioSource switchSound;

    //get batteries trigger:
    private bool isBatteryCollected;
    public GameObject flashLight;
    public GameObject batteries;
    public GameObject zombieToHide;
    public GameObject room2Corridor;
    public GameObject room2StairsUp;

    //get doorKnob puzzle:
    private bool isDoorKnobCollected;
    public GameObject doorKnobToPick;
    public GameObject doorKnobToActivate;
    public GameObject animatedDoor;
    private Animator doorAnimator;

    //axe collection:
    public GameObject axeDoor;
    public GameObject axeMesh;
    public GameObject playerWithAxe;
    private bool isAxeCollected;

    //misc
    private bool carMove;
    private bool lookBehind;
    private bool room4Entry;
    private Light noteLightComp;
    public static bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject areYouSure;

    // Start is called before the first frame update
    void Start()
    {
        playerWithAxe.SetActive(false);
        ghostWoman.SetActive(false);
        noteLight.SetActive(false);
        ghostNMAgent = ghostWoman.GetComponent<NavMeshAgent>();
        noteLightComp = noteLight.GetComponent<Light>();
        noteLightComp.intensity = 2.0f;

        //Taking care of audio
        relief.Stop();
        mainSong.Play();
        stress.Stop();

        doorAnimator = animatedDoor.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isFlashCollected)
            {
                switchSound.Play();
                if (!isBatteryCollected)
                {
                    Debug.Log("No batteries in flashlight. Find batteries");
                }
                else
                {
                    Debug.Log("Flash turned on. Find something to break the lock");
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // First Note
        if (other.CompareTag("Note1Trigger"))
        {
        }

        if (other.CompareTag("Note4Trigger"))
        {
            if (!lookBehind)
            {
                lookBehind = true;
                //mainSong.Stop();
                stress.Play();
                ghostWoman.SetActive(true);
            }
        }

        if (other.CompareTag("Room4EntryTrigger"))
        {
            ghostWoman.SetActive(false);
            if (!room4Entry)
            {
                room4Entry = true;
                stress.Stop();
                relief.Play();
                //mainSong.Play();
            }
        }

        if (other.CompareTag("missingDoorKnob"))
        {
            if (isDoorKnobCollected)
            {
                Debug.Log("Press E to place the missing piece");
            }
            else
            {
                Debug.Log("Find the missing piece to open the door");
            }
        }

        if (other.CompareTag("pickDoorKnob"))
        {
            if (isDoorKnobCollected)
            {
                Debug.Log("Place the missing piece on the cylindrical structure to open the door");
            }
            else
            {
                Debug.Log("Press E to pick the missing piece");
            }
        }

        if (other.CompareTag("getFlashLight"))
        {
            if (!isFlashCollected)
            {
                Debug.Log("Press E to pick Flashlight");
            }
        }

        if (other.CompareTag("getBatteries"))
        {
            if (!isBatteryCollected)
            {
                Debug.Log("Press E to pick batteries and put in flashlight");
            }
        }

        if (other.CompareTag("corrWayBack"))
        {
            if (room4Entry)
            {
                stress.Play();
                ghostWoman.transform.position = new Vector3(40f, 2.5f, 27f);
                ghostWoman.SetActive(true);
                ghostNMAgent.speed = 2.5f;
            }
            else
            {
                ghostWoman.transform.position = new Vector3(40f, 2.5f, 27f);
                ghostNMAgent.speed = 1.0f;
            }
        }

        if (other.CompareTag("getAxe"))
        {
            if (!isAxeCollected)
            {
                Debug.Log("Press E to pick the Axe");
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Note1Trigger"))
        {
            //Once axe is collected user has already seen all notes, hence no need for them to pop
            if (!isAxeCollected)
            {
            Note1.SetActive(true);
            noteLight.SetActive(true);
            }
        }

        if (other.CompareTag("Note2Trigger"))
        {
            if (!isAxeCollected)
            {
            Note2.SetActive(true);
            noteLight.SetActive(true);
            }
        }

        if (other.CompareTag("Note3Trigger"))
        {
            if (!isAxeCollected)
            {
            Note3.SetActive(true);
            noteLight.SetActive(true);
            }
        }

        //Note 4 not turned on so view is not restricted

        if (other.CompareTag("Note5Trigger"))
        {
            if (!isAxeCollected)
            {
            Note5.SetActive(true);
            noteLightComp.intensity = 1.0f;
            noteLight.SetActive(true);
            }
        }

        if (other.CompareTag("Note6Trigger"))
        {
            if (!isAxeCollected)
            {
            Note6.SetActive(true);
            noteLightComp.intensity = 1.0f;
            noteLight.SetActive(true);
            axeDoor.SetActive(false);
            }
        }

        //Note 7 not turned on to maintain the heavy tone of the game

        if (other.CompareTag("getFlashLight"))
        {
            if (!isFlashCollected)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    meshLight.SetActive(false);
                    stairDownOpen.SetActive(false);
                    isFlashCollected = true;
                    Debug.Log("No batteries in the flashlight. Find batteries");
                }
            }
        }

        if (other.CompareTag("getBatteries"))
        {
            if (!isBatteryCollected)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    room2StairsUp.SetActive(false);
                    room2Corridor.SetActive(false);
                    flashLight.SetActive(true);
                    batteries.SetActive(false);
                    zombieToHide.SetActive(false);
                    isBatteryCollected = true;
                    Debug.Log("Press F to toggle Flashlight");
                }
            }
        }

        if (other.CompareTag("missingDoorKnob"))
        { 
            if (isDoorKnobCollected)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    doorKnobToActivate.SetActive(true);
                    doorAnimator.SetTrigger("OpenDoor");
                }
            }
        }

        if (other.CompareTag("pickDoorKnob"))
        {
            if (!isDoorKnobCollected)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    doorKnobToPick.SetActive(false);
                    isDoorKnobCollected = true;
                }
            }
        }

        if (!isAxeCollected)
        {
            if (other.CompareTag("getAxe"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    axeMesh.SetActive(false);
                    playerWithAxe.SetActive(true);
                    isAxeCollected = true;
                    Debug.Log("This will help break the lock in the main room!");
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Note1Trigger"))
        {
            Note1.SetActive(false);
            noteLight.SetActive(false);
        }

        if (other.CompareTag("Note2Trigger"))
        {
            Note2.SetActive(false);
            noteLight.SetActive(false);
        }

        if (other.CompareTag("Note3Trigger"))
        {
            Note3.SetActive(false);
            noteLight.SetActive(false);
        }

        if (other.CompareTag("Note4Trigger"))
        {
            Note4.SetActive(false);
            noteLight.SetActive(false);
        }

        if (other.CompareTag("Note5Trigger"))
        {
            Note5.SetActive(false);
            noteLightComp.intensity = 2.0f;
            noteLight.SetActive(false);
        }

        if (other.CompareTag("Note6Trigger"))
        {
            Note6.SetActive(false);
            noteLightComp.intensity = 2.0f;
            noteLight.SetActive(false);
        }

        if (other.CompareTag("Note7Trigger"))
        {
            Note7.SetActive(false);
            noteLight.SetActive(false);
        }
    }

    IEnumerator waitForSecs(int waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}
