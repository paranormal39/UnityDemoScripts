﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;

        rotation *= Time.deltaTime;
        Cursor.visible = true;

        this.gameObject.transform.Rotate(rotation, 0, 0);

    }
}
