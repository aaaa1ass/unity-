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
            prefab[index],// ������ ������Ʈ
            createPosition[index].position,//��ġ
            prefab[index].transform.rotation
            );
    }

}
