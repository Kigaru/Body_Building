using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideOnPoint : MonoBehaviour
{
    HingeJoint2D hinge;
    bool IsConnected = false;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.enabled = false;
        GetComponent<SpinJoint>().enabled = false;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (IsConnected == false && col.gameObject.tag == "Limb")
        {
            hinge.enabled = true;
            GetComponent<SpinJoint>().enabled = true;
            print("First point that collided: " + transform.InverseTransformPoint(col.contacts[0].point));
            hinge.connectedBody = col.rigidbody;
            hinge.anchor = transform.InverseTransformPoint(col.contacts[0].point);
            gameObject.tag = "Limb";
            gameObject.layer = 8;

            IsConnected = true;
        }

    }
}
