using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TiggerTimeline : MonoBehaviour
{
    public PlayableDirector playable;
    // Update is called once per frame
    public void OnTriggerEnter(Collider collider){
        // timeline will begin playing when triggered 
        //assign the director to the script to be called 
        playable.Play();
    }
}
