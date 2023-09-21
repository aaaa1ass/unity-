using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public Button button;
    public GameObject prefab;
    private bool active = true;
    private float currentTime = 5f;
    public void CreateGeneric()
    {
        active = false;
        Instantiate(
            prefab,// ������ ������Ʈ
            new Vector3(0, -1.25f,0),//��ġ
            prefab.transform.rotation
            ).AddComponent<Delete>();
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
