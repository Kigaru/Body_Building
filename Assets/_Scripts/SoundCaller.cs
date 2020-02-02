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
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playArmSlap();
        }

    }

    void playArmSlap()
    {
        clipChoice = Random.Range(0, slapSounds.Length-1);
        audioSource.PlayOneShot(slapSounds[clipChoice]);
    }
}
