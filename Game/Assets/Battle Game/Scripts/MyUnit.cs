using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUnit : BattleUnit
{
    // Start is called before the first frame update
    void Start()
    {
        attack = 10;
        health = 100;
        speed = 1.5f;

        animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Battle");
    }

    public void Damage()
    {
        target.GetComponent<EnemyUnit>().Hit(attack);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("EnemyUnit"))
        {
            target = other;
            state = State.ATTACK;
        }
    }
}