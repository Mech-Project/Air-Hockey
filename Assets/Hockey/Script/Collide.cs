using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collide : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject HUD;
    public GameObject Menu;
    [SerializeField] private TextMeshProUGUI StatusText;

    void OnCollisionEnter(Collision coll){
        if (coll.collider.name=="Goal" && rb.tag=="Red"){
            StatusText.text = "You Win";
            HUD.SetActive(false);
            Menu.SetActive(true);
        }
    }
}
