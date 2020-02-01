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
    private bool leftHanded;
    [SerializeField]
    private bool player2;
    GameObject parent;
    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.useMotor = true;
    }

    void Update()
    {
       motor = hinge.motor;
       if (Input.GetKey(button))
       {
            if (leftHanded == true)
            {
                motor.motorSpeed = 1600;
                hinge.useMotor = true;
            }
            else
            {
                motor.motorSpeed = -1600;
                hinge.useMotor = true;
            }
       }
       else
       {
            if (leftHanded == true)
            {
                motor.motorSpeed = -800;
                hinge.useMotor = true;
            }
            else
            {
                motor.motorSpeed = 800;
                hinge.useMotor = true;

            }
       }
            hinge.motor = motor;
    }

    public bool isPlayerTwo() 
    {
        return player2;

    }

    public bool isLeftHanded()
    {
        return leftHanded;

    }

    public void setPlayerTwo (bool value)
    {
        player2 = value;

    }
    public void setButton(KeyCode key)
    {
        button = key;
    }
}
