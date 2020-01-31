using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class limbScript : MonoBehaviour
{
    Rigidbody2D rb2D;
    void Start()
    {

        rb2D = GetComponent<Rigidbody2D>();
        rb2D.rotation = 45f;
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.rotation += 1.0f;
    }
}
