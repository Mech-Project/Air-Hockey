using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderVelo : MonoBehaviour
{
    [SerializeField] private Slider SliderV;
    [SerializeField] private TextMeshProUGUI SliderVText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        SliderV.onValueChanged.AddListener(((v)=>{
            SliderVText.text = v.ToString("0.00")+"%";
        }));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
