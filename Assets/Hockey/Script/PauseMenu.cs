using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public GameObject HUD;
    public GameObject Menu;
    public GameObject red;
    public GameObject White;
    [SerializeField] private TextMeshProUGUI StatusText;
    public PlayerMovement MyWhite;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(StatusText.text!="You Win"){
                StatusText.text = "Menu";
            }
            this.Resume();
        }
        bool isstop=true;
        if(red.GetComponent<Rigidbody>().velocity.magnitude > 11){
            isstop=false;
        }
        if((isstop && !(White.GetComponent<Rigidbody>().velocity.magnitude > 11) && !MyWhite.ac && StatusText.text!="You Win")
        ||(red.transform.position.magnitude>60))
        {
            StatusText.text = "You Lose";
            if(!Menu.activeInHierarchy)
            {
                this.Resume();
            }
        }
        
    }

    public void Title()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        HUD.SetActive(!HUD.activeInHierarchy);
        Menu.SetActive(!Menu.activeInHierarchy);
    }
}
