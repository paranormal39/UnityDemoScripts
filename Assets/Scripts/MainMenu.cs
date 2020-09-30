using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    //Used with Ui To change states and peform actions

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonLink(){
        Application.OpenURL("www.google.com");
    }
    public void quitButton(){
        Application.Quit();
    }
    public void PlayButton(){
        //load scene and change to play
    }
    
}
