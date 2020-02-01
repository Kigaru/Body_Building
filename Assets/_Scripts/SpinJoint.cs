using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinJoint : MonoBehaviour
{
    HingeJoint2D hinge;
    JointMotor2D motor;
    [SerializeField]
    private KeyCode button;

    [SerializeField]
    private bool player2;

    GameObject parent;
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.useMotor = true;

        parent = GameObject.FindGameObjectWithTag("Head");
        transform.parent = parent.transform;
    }

    void Update()
    {
       motor = hinge.motor;
       if (Input.GetKey(button))
       {
            if (player2 == true)
            {
                motor.motorSpeed = 800;
                hinge.useMotor = true;
            }
            else
            {
                motor.motorSpeed = -800;
                hinge.useMotor = true;
            }
       }
       else
       {
            if (player2 == true)
            {
                motor.motorSpeed = -400;
                hinge.useMotor = true;
            }
            else
            {
                motor.motorSpeed = 400;
                hinge.useMotor = true;

            }
       }
            hinge.motor = motor;
    }
}
