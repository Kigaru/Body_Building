using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinJoint : MonoBehaviour
{
    HingeJoint2D hinge;
    JointMotor2D motor;
    KeyCode key;
    public KeyCode button;
    public KeyCode button2;

    public bool p2;


    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.useMotor = true;
      
    }

    // Update is called once per frame
    void Update()
    {

        motor = hinge.motor;

        if (p2 == true)
        {
            motor = hinge.motor;

            if (Input.GetKey(button2))
            {
                motor.motorSpeed = 400;
                hinge.useMotor = true;

            }
            else if (Input.GetKey(KeyCode.K))
            {
                motor.motorSpeed = -400;
                hinge.useMotor = true;

            }
            else
            {
                motor.motorSpeed = 0;
                hinge.useMotor = false;

            }
            hinge.motor = motor;
        }

        else {

            if (Input.GetKey(button))
            {
                motor.motorSpeed = 400;
                hinge.useMotor = true;

            }
            else if (Input.GetKey(KeyCode.S))
            {
                motor.motorSpeed = -400;
                hinge.useMotor = true;

            }
            else
            {
                motor.motorSpeed = 0;
                hinge.useMotor = false;

            }
            hinge.motor = motor;
        }

    }
}
