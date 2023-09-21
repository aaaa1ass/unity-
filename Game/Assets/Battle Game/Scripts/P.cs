using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float speed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        direction.x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
