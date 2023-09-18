using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManger : MonoBehaviour
{
    [SerializeField] List<BronzeUnit> bronzeUnit;
    List<Dictionary<string, object>> data;
    private void Awake()
    {
        data = CSVReader.Read("Manage");
    }
    void Start()
    {
        for(int i = 0; i < bronzeUnit.Count; i++)
        {
            bronzeUnit[i].Initialize("Manage",i);
        }
    }

    public void Select(Unit unit)
    {
        for (int i = 0;i < bronzeUnit.Count;i++)
        {
            bronzeUnit[i].gameObject.SetActive(false);
        }
        unit.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
