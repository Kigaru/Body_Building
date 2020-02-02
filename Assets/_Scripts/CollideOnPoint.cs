﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollideOnPoint : MonoBehaviour
{
    HingeJoint2D hinge;
    TextMeshPro textmeshPro;

    bool IsConnected = false;
    KeyCode button;
    string leftButtons = "QAZWSXEDCRFVT";
    string rightButtons = "GBYHNUJMIKOLP";

    GameObject leftLimbCount;
    GameObject RightLimbCount;
    // Start is called before the first frame update
    void Start()
    {
        leftLimbCount = GameObject.FindGameObjectWithTag("LeftLimbCount");
        RightLimbCount = GameObject.FindGameObjectWithTag("RightLimbCount");

        hinge = GetComponent<HingeJoint2D>();
        hinge.enabled = false;
        GetComponent<SpinJoint>().enabled = false;
        textmeshPro = GetComponentInChildren<TextMeshPro>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        int randomInt = Random.Range(0, 12);
        print(randomInt);
        if (IsConnected == false && col.gameObject.tag == "Limb")
        {
            hinge.enabled = true;
            GetComponent<SpinJoint>().enabled = true;
            hinge.connectedBody = col.gameObject.GetComponent<Rigidbody2D>();
            hinge.anchor = transform.InverseTransformPoint(col.contacts[0].point);
            gameObject.tag = "Limb";
            gameObject.layer = 8;
            JointAngleLimits2D lim = hinge.limits;
            if (col.gameObject.GetComponent<SpinJoint>().isLeftHanded())
            {
                if (transform.rotation.eulerAngles.z > 90 && transform.rotation.eulerAngles.z < 180 || transform.rotation.eulerAngles.z < 360 && transform.rotation.eulerAngles.z > 270)
                {
                    lim.max = transform.rotation.eulerAngles.z - 90 - 120;
                    lim.min = transform.rotation.eulerAngles.z - 90;
                }
                else
                {
                    lim.max = transform.rotation.eulerAngles.z;
                    lim.min = transform.rotation.eulerAngles.z - 120;
                }
            }
            else
            {
                if (transform.rotation.eulerAngles.z > 90 && transform.rotation.eulerAngles.z < 180 || transform.rotation.eulerAngles.z < 360 && transform.rotation.eulerAngles.z > 270)
                {
                    lim.max = (transform.rotation.eulerAngles.z - 90 - 120) * -1;
                    lim.min = (transform.rotation.eulerAngles.z - 90) * -1;
                }
                else
                {
                    lim.max = (transform.rotation.eulerAngles.z) * -1;
                    lim.min = (transform.rotation.eulerAngles.z - 120) * -1;
                }
            }
            hinge.limits = lim;
            IsConnected = true;
            transform.parent = col.transform.parent;
            if (col.gameObject.GetComponent<SpinJoint>().isPlayerTwo())
            {
                RightLimbCount.GetComponent<updateNumberText>().updateLimbCount();
                button = (KeyCode)System.Enum.Parse(typeof(KeyCode), rightButtons[randomInt].ToString());
                GetComponent<SpinJoint>().setButton(button);
                GetComponent<SpinJoint>().setPlayerTwo(true);
                textmeshPro.SetText(rightButtons[randomInt].ToString());
                GetComponent<SpriteRenderer>().color = Color.red;
            }
            else
            {
                leftLimbCount.GetComponent<updateNumberText>().updateLimbCount();
                button = (KeyCode)System.Enum.Parse(typeof(KeyCode), leftButtons[randomInt].ToString());
                GetComponent<SpinJoint>().setButton(button);
                GetComponent<SpinJoint>().setPlayerTwo(false);
                textmeshPro.SetText(leftButtons[randomInt].ToString());
                GetComponent<SpriteRenderer>().color = Color.blue;

            }
        }
    }
}
