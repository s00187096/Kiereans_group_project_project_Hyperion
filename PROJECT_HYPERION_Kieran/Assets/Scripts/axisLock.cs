﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axisLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = 0;
        pos.x = 0;
        transform.position = pos;

    }
}
