using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Create1 : MonoBehaviour
{
    public Button button;
    public GameObject prefab;
    private bool active = true;
    private float currentTime = 5f;
    public float loc = 0;
    public float dir = 0;
    public void CreateGeneric()
    {
        active = false;
        Instantiate(
            prefab,// 생성할 오브젝트
            new Vector3(loc, 0,0),//위치
            prefab.transform.rotation
            ).AddComponent<P>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( !active )
        {
            button.interactable = false;
            currentTime -= Time.deltaTime;
            button.image.fillAmount = currentTime / 5f;
            if( currentTime <= 0)
            {
                active = true;
                button.interactable = true;
                button.image.fillAmount = currentTime = 5f;
            }
        }
    }
}
