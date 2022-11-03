using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderAngle : MonoBehaviour
{
    [SerializeField] private Slider SliderA;
    [SerializeField] private TextMeshProUGUI SliderAText;
    public GameObject objectToRotate;
    private float previousValue;
    // Start is called before the first frame update
    void Awake()
    {
        this.SliderA.onValueChanged.AddListener (this.OnSliderChanged);
        this.previousValue = this.SliderA.value;
    }

    // Update is called once per frame
    void OnSliderChanged(float value)
    {
        float delta = value - this.previousValue;
        this.objectToRotate.transform.Rotate (Vector3.forward * delta);
        this.previousValue = value;
        this.SliderAText.text = value.ToString("0.00")+"°";
    }
}
