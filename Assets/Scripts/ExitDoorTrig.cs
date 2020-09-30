using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitDoorTrig : MonoBehaviour
{
    public UnityEvent exitdoor;
    
  

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Keys")
        {
            exitdoor.Invoke();
        }
    }
}
