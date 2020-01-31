using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinJoint : MonoBehaviour
{
    HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();

    }

    // Update is called once per frame
    void Update()
    {
        hinge.useMotor = true;
    }
}
