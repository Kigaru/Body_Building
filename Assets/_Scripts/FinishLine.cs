using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField]
    int exitNumber;
    [SerializeField]
    GameObject player1, player2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "head1")
        {
            backToMenu.head = collision.gameObject;
            backToMenu.exitNumber = exitNumber;
            backToMenu.scoreX = player1.GetComponent<updateNumberText>().LimbsCount;
            backToMenu.scoreY = player2.GetComponent<updateNumberText>().LimbsCount;
            SceneManager.LoadScene("End");
        }
    }

}
