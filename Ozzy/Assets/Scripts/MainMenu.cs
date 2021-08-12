using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject areYouSure;
    public GameObject mainMenu;
    public GameObject controlsMenu;

    public void Start()
    {
        settingsMenu.SetActive(false);
        areYouSure.SetActive(false);
        controlsMenu.SetActive(false);
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

    public void areYouSureMenu()
    {
        mainMenu.SetActive(false);
        areYouSure.SetActive(true);
    }

    public void backToMain()
    {
        mainMenu.SetActive(true);
        areYouSure.SetActive(false);
        settingsMenu.SetActive(false);
    }

    public void yesQuit()
    {
        Application.Quit();
    }

    public void controls()
    {
        settingsMenu.SetActive(false);
        controlsMenu.SetActive(true);
    }

    public void backToSettings()
    {
        controlsMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
