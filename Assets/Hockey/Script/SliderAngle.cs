using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderAngle : MonoBehaviour
{
    [SerializeField] private Slider SliderA;
    [SerializeField] private TextMeshProUGUI SliderAText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        SliderA.onValueChanged.AddListener(((v)=>{
            SliderAText.text = v.ToString("0.00")+"°";
        }));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
