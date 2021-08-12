using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject areYouSure;
    public GameObject settings;
    public GameObject controls;
    public static bool isPaused;

    void Start()
    {
        turnAllMenusOff();

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
        isPaused = false;
        Time.timeScale = 1;
        turnAllMenusOff();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            Time.timeScale = 0;
            isPaused = true;
            pauseMenu.SetActive(true);
        }
    }

}
