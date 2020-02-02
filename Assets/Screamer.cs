using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public bool scream = true;
    private AudioSource screamSource;
    public AudioClip[] screams;
    private int clipChoice;

    void Start()
    {        
        screamSource = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scream == true)
        {
            scream = false;
            StartCoroutine(waitToScream());
        }
    }

    IEnumerator waitToScream()
    {
        print("waiting to scream");
        yield return new WaitForSecondsRealtime(5);
        clipChoice = Random.Range(0, screams.Length - 1);
        screamSource.PlayOneShot(screams[clipChoice]);
        print("aagh");
        yield return new WaitForSecondsRealtime(5);
        scream = true;
        print("done");
    }
}
