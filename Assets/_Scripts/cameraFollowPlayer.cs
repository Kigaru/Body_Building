using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    //public int distanceFromPlayer;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -100);
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
