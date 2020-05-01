using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zaxis_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //model is orientated so the y axis is facing towards the finish so the code had to change from z to  y
    void Update()
    {
        transform.Translate(0, 2, 0);//transform.Translate(x,y,z)
    }
}
