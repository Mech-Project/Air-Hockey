using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public Rigidbody rb;
    void OnCollisionEnter(Collision coll){
        if (coll.collider.name=="White"){
            float momemtumZ = (coll.relativeVelocity.z * coll.rigidbody.mass);
            float momemtumX = (coll.relativeVelocity.x * coll.rigidbody.mass);
            float veloZ = momemtumZ/rb.mass;
            float veloX = momemtumX/rb.mass;
            rb.velocity = new Vector3(veloX,0,veloZ);
        }
        if (coll.collider.tag=="Red"){
            Debug.Log("Stop");
            rb.velocity = new Vector3(0,0,0);
        }
        if (coll.collider.name=="Goal" && rb.name=="Red"){
            Debug.Log("Goal!!!");
        }
    }
}
