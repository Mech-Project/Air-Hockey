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
    public bool ac = true;
    public GameObject arrow;
    public GameObject red;
    public int count;

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
        if(count<=0){
            ac=false;
            arrow.SetActive(false);
        }
        if(ac && rb.velocity.magnitude<=10 && red.GetComponent<Rigidbody>().velocity.magnitude<=10){
            arrow.SetActive(true);
            arrow.transform.position = rb.position+Vector3.up;
            if(Input.GetKeyDown(KeyCode.Space)){
                float real = SliderV.value/1.2f;
                float veloX = (float)(real*Math.Cos(SliderA.value*0.0174533));
                float veloZ = (float)(real*Math.Sin(SliderA.value*0.0174533));
                rb.velocity = new Vector3(veloX, 0, veloZ);
                count--;
                arrow.SetActive(false);
            }
        }
    }
}
