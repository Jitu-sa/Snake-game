using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] int sceneindex;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneindex);
        }

        else if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
