using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drivetrain : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButton("pedal"))
        { 
            //rb.AddForce(transform.forward * 0, ForceMode2D.Force);

            rb.AddTorque(-10, ForceMode2D.Impulse);
        }
    }
}
