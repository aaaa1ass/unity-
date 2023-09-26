using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUnit : BattleUnit
{
    protected HPBar hpBar;
    // Start is called before the first frame update
    void Start()
    {
        attack = 10;
        health = 100;
        speed = 1.5f;
        maxHP = health;

        animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Battle");
        hpBar = GetComponent<HPBar>();
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

    public override void Hit(float damage)
    {
        health -= damage;
        hpBar.CurrentHP(health, maxHP);
        if (health <= 0)
        {
            state = State.DIE;
            target.GetComponent<EnemyUnit>().state = State.RUN;
        }
    }

    protected override void Move()
    {
        speed = 1.5f;
        animator.SetBool("Attack", false);
        transform.Translate(-1 * transform.right * speed * Time.deltaTime);
    }
}
