using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    public MenuScript menu;
    // Start is called before the first frame update
    void Start()
    {
        // sn = GameObject.GetComponent<MenuScript>();
        menu=GameObject.Find("Menu").GetComponent<MenuScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pause(){
        Debug.Log("Paused");
        menu.pauseGame();
    } 
}
