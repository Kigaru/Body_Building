using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinJoint : MonoBehaviour
{
    HingeJoint2D hinge;
    JointMotor2D motor;
    KeyCode key;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.useMotor = true;
      
    }

    // Update is called once per frame
    void Update()
    {

        motor = hinge.motor;

        if (Input.GetKey(KeyCode.A))
        {
            motor.motorSpeed = 400;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            motor.motorSpeed = -400;
        }
        else
        {
            motor.motorSpeed = 0;
        }
        hinge.motor = motor;

    }
}
