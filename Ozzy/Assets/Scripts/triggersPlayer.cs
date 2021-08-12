using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class triggersPlayer : MonoBehaviour
{
    private PlayableDirector cutscene;
    public GameObject cutsceneObject;
    public GameObject fpsController;
    public GameObject cutsceneLady;
    public GameObject nextSceneLoader;
    private bool isIslandFound = false;

    private void Start()
    {
        fpsController.SetActive(true);
        cutsceneLady.SetActive(false);
        nextSceneLoader.SetActive(false);
        cutscene = cutsceneObject.GetComponent<PlayableDirector>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("houseEntry"))
        {
            cutsceneLady.SetActive(true);
            cutscene.Play();
            fpsController.SetActive(false);
        }

        if (other.CompareTag("islandFound"))
        {
            isIslandFound = true;
        }

        if (other.CompareTag("underground"))
        {
            if (isIslandFound)
            {
                fpsController.transform.position = new Vector3(-700, 13, -120);
            }
            else
            {
                fpsController.transform.position = new Vector3(-740, 15, -350);
            }

        }
    }
}
