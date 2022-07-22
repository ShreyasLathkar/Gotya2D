using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject Player;
    public GameObject StartPoint;
    public System.String scene;

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
