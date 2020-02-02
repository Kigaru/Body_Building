using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{
    public static GameObject head;
    public static int scoreX;
    public static int scoreY;
    public static int exitNumber;
    public string scene;
    public void LoadScene()
    {
        exitNumber = 0;
        scoreX = 0;
        scoreY = 0;
        head = null;
        SceneManager.LoadScene(scene);
    }
}
