using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanSpinJoint : MonoBehaviour
{
    HingeJoint2D hinge;
    JointMotor2D motor;
    KeyCode key;
    public bool p2;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.useMotor = true;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (p2 == true)
        {
            motor = hinge.motor;

            if (Input.GetKey(KeyCode.K))
            {
                motor.motorSpeed = 400;
            }
            else if (Input.GetKey(KeyCode.L))
            {
                motor.motorSpeed = -400;
            }
            else
            {
                motor.motorSpeed = 0;
            }
            hinge.motor = motor;
        }

        else
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
}
