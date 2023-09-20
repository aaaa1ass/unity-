using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float speed = 1.0f;
    [SerializeField] Rigidbody rigidBody;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        direction.Normalize();
    }
    private void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("面倒");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("面倒 吝");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("面倒 场");
    }
}
