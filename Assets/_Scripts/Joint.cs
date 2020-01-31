using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour
{
    [SerializeField]
    KeyCode key;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(key == KeyCode.A)
        {
            print(gameObject.transform.rotation.eulerAngles);
        }
        if(Input.GetKey(key))
        {
            gameObject.transform.rotation = Quaternion.Euler(new Vector3(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z + 30 * Time.deltaTime));
        }
    }
}
