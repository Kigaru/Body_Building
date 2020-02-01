using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    void OnCollisionStay(Collision stay)
    {
        print("we're in");
        if (stay.gameObject.tag == "Grabbable")
        {
            if (Input.GetKey(KeyCode.D))
            {
                GetComponent<HingeJoint2D>().connectedBody = stay.gameObject.GetComponent<Rigidbody2D>();
                transform.parent.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                print("grab!");
            }
        }
    }
}