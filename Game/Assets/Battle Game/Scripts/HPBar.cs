using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField] Slider hpBar;

    private void Awake()
    {
        hpBar = GameObject.Find("Slider").GetComponentInChildren<Slider>();
    }

    public void CurrentHP(float hp, float maxHP)
    {
        hpBar.value = hp/maxHP;
    }
}
