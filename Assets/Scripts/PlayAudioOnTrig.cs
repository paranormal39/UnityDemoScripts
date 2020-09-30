﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTrig : MonoBehaviour
{

    public AudioSource audioSource;

    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(clip);
    }

    
}
