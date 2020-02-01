using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddChain : MonoBehaviour
{

    public GameObject prefabArm;
    void Start()
    {
        Instantiate(prefabArm, transform.position, transform.rotation);
        
    }

    // Update is called once per frame
  
}
