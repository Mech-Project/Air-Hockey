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
        float random = Random.Range(0, 5);
        rb.mass = random;
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.y>0.15){
            rb.velocity = new Vector3(rb.velocity.x, -1, rb.velocity.z);
        }
    }
}
