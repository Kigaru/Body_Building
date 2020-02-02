using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenManager : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    TextMeshProUGUI player1Text, player2Text, exitDiscovered;

    // Start is called before the first frame update
    void Start()
    {
        player = backToMenu.head;
        player1Text.SetText("Player 1: " + backToMenu.scoreX);
        player2Text.SetText("Player 2: " + backToMenu.scoreY);
        exitDiscovered.SetText("Exit " + backToMenu.exitNumber + "  Discovered!");
    }

}
