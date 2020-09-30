using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class teleport : MonoBehaviour
    {
        // Make sure to change the auto sync transform in the project settings under physics its a lil check box
        public Transform target;
        public GameObject player;

        void OnTriggerEnter(Collider coll)
        {
            //player.gameObject.GetComponent<FirstPersonController>().turnOfCc();
            player.transform.position = target.transform.position;
           // player.gameObject.GetComponent<FirstPersonController>().turnOnCc();
        }
    }

