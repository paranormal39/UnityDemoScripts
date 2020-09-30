using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //bottom section
        if (Input.touchCount > 1 && Input.GetTouch(0).position.y < Screen.height / 2) 
        {
            Debug.Log("your bottom");
        }
        //top script
       if(Input.touchCount > 1)
        {
            if (Input.GetTouch(0).position.y > Screen.height / 2)
            {
                // Debug.Log(Input.GetTouch(0).position);
                Debug.Log("your top  ");
            }
        }

      


    }
}
