using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1.0f; 
    void Start()
    {

    }

    void Update()
    {
        #region Input.GetKeyDown
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += new Vector3(0,0,1);
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, -1);
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += new Vector3(1, 0, 0);
        //}
        //else if(Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1, 0, 0);
        //}
        #endregion

        // -1 ~ 1 ������ ���� ��ȯ
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // Time.deltaTime: �� �������� �Ϸ�Ǳ���� �ɸ� �ð�
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
