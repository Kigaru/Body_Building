using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   

    public void LoadLimbRant()
    {
        SceneManager.LoadScene("Limbyrinth");
    }
    public void LoadVerses()
    {
        SceneManager.LoadScene("VsRace");
    }

}
