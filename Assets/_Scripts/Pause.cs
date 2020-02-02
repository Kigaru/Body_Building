using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool GameIsPaused = false;
    bool ResumeButtonPressed = false;
    public GameObject pMenu;

    void Start()
    {
        //pMenu = GameObject.FindGameObjectWithTag("Pause Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paws();
            }
        }
    }

    public void Resume()
    {
        pMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    void Paws()
    {
        pMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
