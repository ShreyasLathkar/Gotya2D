using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool Paused;
    public GameObject PauseUI;
    // Update is called once per frame

    private void Start()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    void Update()

    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }

    }
    void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    private void pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }
    public void menuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void levelButton()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void resumeButton()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
}
