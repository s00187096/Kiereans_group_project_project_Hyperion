using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydeath : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        throw new NotImplementedException();
    }
}
