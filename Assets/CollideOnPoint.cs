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


    void OnTriggerEnter2D(Collider2D col)
    {
        if (IsConnected == false && col.gameObject.tag == "Limb")
        {
            hinge.enabled = true;
            GetComponent<SpinJoint>().enabled = true;
            hinge.connectedBody = col.GetComponent<Rigidbody2D>();
            gameObject.tag = "Limb";
            gameObject.layer = 8;
            JointAngleLimits2D lim = hinge.limits;
            if (col.GetComponent<SpinJoint>().isLeftHanded())
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
                    lim.max = (transform.rotation.eulerAngles.z - 90 - 120)*-1;
                    lim.min = (transform.rotation.eulerAngles.z - 90)*-1;
                }
                else
                {
                    lim.max = (transform.rotation.eulerAngles.z)*-1;
                    lim.min = (transform.rotation.eulerAngles.z - 120)*-1;
                }
            }
            hinge.limits = lim;
            IsConnected = true;
            transform.parent = col.transform.parent;
            if(col.GetComponent<SpinJoint>().isPlayerTwo())
            {
                GetComponent<SpinJoint>().setButton(KeyCode.P);
                GetComponent<SpinJoint>().setPlayerTwo(true);
            }
            else
            {
                GetComponent<SpinJoint>().setButton(KeyCode.R);
                GetComponent<SpinJoint>().setPlayerTwo(false);

            }
            //Player 1:
            //QAZWSXEDCRFVT
            //Player 2:
            //GBYHNUJMIKOLP

        }

    }
}
