using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class updateNumberText : MonoBehaviour
{
    public int LimbsCount = 0;
    TextMeshProUGUI textmeshPro;
    public string side;

    private void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }
    public void updateLimbCount()
    {
        LimbsCount++;
        textmeshPro.SetText(side + LimbsCount);
    }
}