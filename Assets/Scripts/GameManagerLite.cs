using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerLite : MonoBehaviour {
    
    public enum state
    {
        InMenu,
        playing,
        pause,
        gameover
           }

    private state currently;

    private void Awake()
    {
        currently = state.InMenu;
    }


	// Update is called once per frame
	void Update () {
            switch(currently){
                case state.playing:

                break;

                case state.InMenu:

                break;

                case state.pause:

                break;

                case state.gameover:

                break;
            }

	}
    void Play()
    {
        currently = state.playing;

    }

    public void SetGameOver(){
        currently = state.gameover;
    }
}
