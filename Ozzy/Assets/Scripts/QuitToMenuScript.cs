using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMenuScript : MonoBehaviour
{
    public GameObject areYouSure;
    public GameObject pauseMenu;
    public void Yes()
    {
        SceneManager.LoadScene(0);
    }

    public void No()
    {
        areYouSure.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
