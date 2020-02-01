using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinJoint : MonoBehaviour
{
    HingeJoint2D hinge;
    JointMotor2D motor;
    KeyCode key;
    [SerializeField]
    private KeyCode p1button;
    [SerializeField]
    private KeyCode p1button2;
    [SerializeField]
    private KeyCode p2button;
    [SerializeField]
    private KeyCode p2button2;

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

            if (Input.GetKey(p2button2))
            {
                motor.motorSpeed = 400;
                hinge.useMotor = true;

            }
            else if (Input.GetKey(p2button))
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

            if (Input.GetKey(p1button))
            {
                motor.motorSpeed = 400;
                hinge.useMotor = true;

            }
            else if (Input.GetKey(p1button2))
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
