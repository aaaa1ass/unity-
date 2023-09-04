using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public int[] ints;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < ints.Length; i++)
        {
            Debug.Log(ints[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
