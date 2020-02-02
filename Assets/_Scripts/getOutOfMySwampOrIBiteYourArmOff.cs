using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getOutOfMySwampOrIBiteYourArmOff : MonoBehaviour
{
    [SerializeField]
    Sprite[] sprites;
    [SerializeField]
    GameObject[] arms;
    [SerializeField]
    float minX, maxX;
    [SerializeField]
    float waitTime = 0.5f;
    [SerializeField]
    GameObject player;

    private IEnumerator coroutine;
        
    void Start()
    {
        coroutine = WaitAndPrint();
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndPrint()
    {
        while (true)
        {
            float posX = Random.Range(player.transform.position.x + minX, player.transform.position.x + maxX); ;
            GameObject arm = Instantiate(arms[Random.Range(0, 1)],new Vector3(posX,player.transform.position.y + 10,0),Quaternion.identity);
            arm.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length - 1)];
            yield return new WaitForSeconds(waitTime);
        }
    }

}
