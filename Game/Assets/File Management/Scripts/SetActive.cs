using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    [SerializeField] List<GameObject> gameObjects;
    private int select = 0;
    private void Awake()
    {
        SelectUnit();
    }
    public void SelectUnit(int select = 0)
    {
        for (int i = 0; i < gameObjects.Count; i++)
        {
            if(select == i)
            {
                this.select = select;
                gameObjects[i].SetActive(true);
            }
            else
            {
                gameObjects[i].SetActive(false);
            }
        }
    }

    public void DecideUnit()
    {
        DontDestroyOnLoad(gameObjects[this.select]);
    }
}
