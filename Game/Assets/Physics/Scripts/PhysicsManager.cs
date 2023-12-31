using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsManager : MonoBehaviour
{
    private Ray ray;
    private RaycastHit rayCastHit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity))
            {
                if (rayCastHit.collider.CompareTag("BilliardBall"))
                {
                    rayCastHit.collider.GetComponent<Rigidbody>().Sleep();
                }
            }
        }
    }
}
