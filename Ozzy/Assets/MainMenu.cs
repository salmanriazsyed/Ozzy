using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject areYouSure;
    public GameObject mainMenu;

    public void Start()
    {
        settingsMenu.SetActive(false);
        areYouSure.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void newGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Settings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void quitGame()
    {
        mainMenu.SetActive(false);
        areYouSure.SetActive(true);
    }
}
