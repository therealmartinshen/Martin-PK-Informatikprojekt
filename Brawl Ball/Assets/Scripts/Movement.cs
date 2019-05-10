using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float player1spd = 5;
    Rigidbody myRigidbody;
    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
    }
}
