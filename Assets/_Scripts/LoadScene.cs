using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLimbRant()
    {
        SceneManager.LoadScene("Limberick");
    }
    public void LoadVerses()
    {
        SceneManager.LoadScene("VsRace");
    }

}
