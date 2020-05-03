using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        float moo = Input.GetAxis("Vertical");
        float meow = Input.GetAxis("Horizontal");
        if (moo != 0)
        {
            meow = 0;
        }
        transform.position += new Vector3(meow, moo, 0);


    }
}
