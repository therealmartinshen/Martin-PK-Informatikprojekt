using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerspd = 10;
    public float knockback = 1;
    [Range(0, 1)]
    public int Player = 0;
    Rigidbody myRigidbody;
    private Vector3 move;
    private float h = 0;
    private float v = 0;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (GameObject.Find("Manager").GetComponent<Game>().isControl)
        {
            //CONTROL NORMAL
            if (Player == 0)
            {
                h = Input.GetAxis("Horizontal1");
                v = Input.GetAxis("Vertical1");
            }
            else if (Player == 1)
            {
                h = Input.GetAxis("Horizontal2");
                v = Input.GetAxis("Vertical2");
            }
            //player movement
            move = new Vector3(h, 0, v);
            myRigidbody.AddForce(move * playerspd);

            //SPEED LIMIT

        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        collision.rigidbody.AddForce(move * knockback, ForceMode.Impulse);
        myRigidbody.AddForce(0.5f * -move * knockback, ForceMode.Impulse);
    }
}
