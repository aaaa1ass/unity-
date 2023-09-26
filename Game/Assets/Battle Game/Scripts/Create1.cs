using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Create1 : MonoBehaviour
{
    public Transform[] createPosition;
    public GameObject[] prefab;


    public void CreateUnit(int index)
    {
        Instantiate(
            prefab[index],// 생성할 오브젝트
            createPosition[index].position,//위치
            prefab[index].transform.rotation
            );
    }

}
