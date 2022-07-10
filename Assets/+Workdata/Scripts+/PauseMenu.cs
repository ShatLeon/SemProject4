using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject grey;
    public GameObject flyer;

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void Leave()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            grey.SetActive(true);
            flyer.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
