using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    TextMeshPro textmeshPro;
    float time;

    void Start()
    {
        textmeshPro = GetComponentInChildren<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
       
        textmeshPro.SetText((time % 120).ToString("f2"));
    }
}
