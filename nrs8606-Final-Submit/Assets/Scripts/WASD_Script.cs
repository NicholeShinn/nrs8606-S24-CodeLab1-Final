using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Script : MonoBehaviour
{
    Rigidbody rb;
    public float forceAmt = 10;

    public static WASD_Script instance;

    private void Awake()
    {
        if (instance == null) //if the instance variable has not been set
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else //if there is already a singleton of this type, we kill all but 1
        {
            Destroy(gameObject);
        }
    }

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
            rb.AddForce(Vector3.up.normalized * forceAmt);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left.normalized * forceAmt);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down.normalized * forceAmt);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right.normalized * forceAmt);
        }

    }
}
