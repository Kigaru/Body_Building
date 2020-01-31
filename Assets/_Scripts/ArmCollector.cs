using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmCollector : MonoBehaviour
{
    public GameObject armPiece;
    public GameObject spawnPoint;
    private GameObject nextArm;
    
    void Start() 
    {
        print("started");
        //ForeArmColl = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        print("it's ya boy");
    }

    void OnTriggerEnter(Collider coll)
    {
        print("I'm in");
        if (coll.gameObject.tag == "Untagged")
        {
            print("hit");
            Destroy(coll.gameObject);
            nextArm = Instantiate(armPiece, spawnPoint.transform);
            nextArm.transform.parent = transform.parent;
            nextArm.GetComponent<HingeJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
            this.enabled = false;
        }
    }
}