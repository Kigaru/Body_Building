using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndRace : MonoBehaviour
{
    public TextMeshPro textmeshProWin;
    public GameObject fall;
    public string winText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Limb")
        {
            textmeshProWin.SetText(winText);
            fall.AddComponent<Rigidbody2D>();
        }
    }
}
