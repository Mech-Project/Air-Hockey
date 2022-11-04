using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.y>0.15){
            rb.velocity = new Vector3(rb.velocity.x, -10, rb.velocity.z);
        }
        else
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        }
    }
}
