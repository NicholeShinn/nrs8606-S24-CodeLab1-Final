using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Script : MonoBehaviour
{
    Rigidbody rb;
    public float forceAmt = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * forceAmt);
        }
        
    }
}
