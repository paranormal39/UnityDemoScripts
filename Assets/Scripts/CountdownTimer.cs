using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timer;
    public Text Timetext;
    // Start is called before the first frame update
    void Start()
    {
        timer = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        Timetext.text = timer.ToString();
        timer -= Time.deltaTime;
        if(timer <= .01f){
            //rest the time or invoke a event when its done 
            //
            timer += 60f;
        }
    }
}
