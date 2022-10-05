using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private Slider SliderV;
    [SerializeField] private Slider SliderA;

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.y>0.15){
            rb.velocity = new Vector3(rb.velocity.x, -1, rb.velocity.z);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            float veloX = (float)(SliderV.value*Math.Cos(SliderA.value*0.0174533));
            float veloZ = (float)(SliderV.value*Math.Sin(SliderA.value*0.0174533));
            rb.velocity = new Vector3(veloX, 0, veloZ);
        }
    }
}
