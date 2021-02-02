using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasdController : MonoBehaviour
{
    public float forceAmt = 10;
    public Rigidbody rb;
    public string nate;
    // Start is called before the first frame update
    void Start()
    {
        nate = "CoolBoy";
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceAmt);
        }

    }
}
