using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RotateZ : Cube
{
    // Start is called before the first frame update
    void Start()
    {
       direction = new Vector3(0, 0, 1);
    }

}
