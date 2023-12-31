using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject moon;
    public GameObject origin;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotateCoroutine());
    }

    IEnumerator RotateCoroutine()
    {
        while (true)
        {
            transform.RotateAround(
                origin.transform.position,
                Vector3.down,
                speed * Time.deltaTime);

            moon.transform.Rotate(0.1f, 0.1f, 0.1f);

            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
