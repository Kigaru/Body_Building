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

    void OnTriggerEnter(Collider hit)
    {
        print("I'm in");
        if (hit.gameObject.tag == "Finish")
        {
            print("hit");
            Destroy(hit.gameObject);
            nextArm = Instantiate(armPiece, spawnPoint.transform);
            nextArm.transform.parent = transform.parent;
            nextArm.GetComponent<HingeJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
            this.enabled = false;
        }
    }
}