using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShotLeft : MonoBehaviour
{
    public PlayerMovement shotCount;
    [SerializeField] private TextMeshProUGUI ShotLeftText;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        ShotLeftText.text = "Shots Left: " + shotCount.count.ToString();
    }
}
