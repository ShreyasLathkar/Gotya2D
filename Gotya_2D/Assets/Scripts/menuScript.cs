using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}
