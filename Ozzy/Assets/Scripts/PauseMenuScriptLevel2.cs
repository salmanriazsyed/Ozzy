using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScriptLevel2 : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject areYouSure;
    public GameObject settings;
    public GameObject controls;
    public GameObject captions;
    public static bool isPaused;

    void Start()
    {
        turnAllMenusOff();
        captions.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseGame();
        }
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void resume()
    {
        pauseGame();
    }

    public void quitToMainMenu()
    {
        pauseMenu.SetActive(false);
        areYouSure.SetActive(true);
    }


    public void settingsMenu()
    {
        turnAllMenusOff();
        settings.SetActive(true);
    }

    public void controlsMenu()
    {
        settings.SetActive(false);
        controls.SetActive(true);
    }

    public void backToMain()
    {
        turnAllMenusOff();
        pauseMenu.SetActive(true);
    }

    private void turnAllMenusOff()
    {
        pauseMenu.SetActive(false);
        areYouSure.SetActive(false);
        settings.SetActive(false);
        controls.SetActive(false);
    }

    public void yesQuit()
    {
        SceneManager.LoadScene(0);
    }

    void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            turnAllMenusOff();
            captions.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            isPaused = true;
            captions.SetActive(false);
            pauseMenu.SetActive(true);
        }
    }

}
