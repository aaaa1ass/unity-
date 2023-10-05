using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Input.GetAxisRaw("Mouse ScrollWheel") * -1 * 10;

        mainCamera.fieldOfView = Mathf.Clamp(
            mainCamera.fieldOfView,
            20.0f,
            60.0f
            );
        mainCamera.fieldOfView += distance;
    }
}
