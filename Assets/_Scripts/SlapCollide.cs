using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapCollide : MonoBehaviour
{
    public AudioClip[] crash;
    private int clipChoice;

    private AudioSource source;

    private float lowPitch = 0.1f;
    private float highPitch = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        source = gameObject.AddComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Limb")
        {
            print("hit");
            clipChoice = Random.Range(0, crash.Length - 1);

            float hitVol = collision.relativeVelocity.magnitude * 0.2f;
            source.pitch = Random.Range(lowPitch, highPitch);

            if (collision.relativeVelocity.magnitude < 10)
            {
                source.volume = .3f;
                source.PlayOneShot(crash[clipChoice], 1);
            }
            else
            {
                source.volume = 1;

                source.PlayOneShot(crash[clipChoice], 1);

            }

        }
    }

}
