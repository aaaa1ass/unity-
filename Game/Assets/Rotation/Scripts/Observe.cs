using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject target;
    public void EarthObservation() 
    {
        StartCoroutine(LookCoroutine());
    }

    public IEnumerator LookCoroutine()
    {
        transform.LookAt(target.transform);
        yield return new WaitForSeconds(1);
        transform.rotation = Quaternion.Euler(15,90,0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
