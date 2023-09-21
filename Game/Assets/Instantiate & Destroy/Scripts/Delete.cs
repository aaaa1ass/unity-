using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private int random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(1, 5);
        Destroy(gameObject,random);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
