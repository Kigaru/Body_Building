using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCaller : MonoBehaviour
{
    private AudioSource audioSource;
    private int clipChoice;

    public AudioClip[] slapSounds;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playArmSlap();
        }

    }

    public void playArmSlap()
    {
        clipChoice = Random.Range(0, slapSounds.Length-1);
        audioSource.PlayOneShot(slapSounds[clipChoice]);
    }
}
