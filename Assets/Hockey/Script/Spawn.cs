using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    public Vector3 randomSpawnPosition;
    public GameObject red;
    public GameObject HUD;
    public GameObject Menu;
    public PlayerMovement MyWhite;
    public GameObject White;
    public GameObject arrow;
    [SerializeField] private TextMeshProUGUI StatusText;

    void Start()
    {
        this.randomSpawnPosition = new Vector3(Random.Range(-20, 5), 0.15f, Random.Range(-5, 5));
        red.transform.position=randomSpawnPosition;
    }

    public void Respawn()
    {
        this.Re();
    }

    public void Restart()
    {
        this.randomSpawnPosition = new Vector3(Random.Range(-20, 5), 0.15f, Random.Range(-5, 5));
        this.Re();
    }

    public void Re()
    {
        red.transform.position=randomSpawnPosition;
        red.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Vector3 transpos=new Vector3(-20.86f,0.15f,0);
        White.transform.position=transpos;
        arrow.SetActive(true);
        MyWhite.ac=true;
        this.Resume();
    }
    public void Resume()
    {
        StatusText.text = "Menu";
        HUD.SetActive(!HUD.activeInHierarchy);
        Menu.SetActive(!Menu.activeInHierarchy);
    }
}
