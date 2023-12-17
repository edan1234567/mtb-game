using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumping : MonoBehaviour
{
    private Rigidbody2D rb;

    public float pop;
    public float pump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(transform.up * pump, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(transform.up * pop, ForceMode2D.Impulse);
        }
    }
}
