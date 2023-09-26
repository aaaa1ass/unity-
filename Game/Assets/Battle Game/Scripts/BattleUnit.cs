using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State { 
RUN,
ATTACK,
DIE
}
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(HPBar))]

public class BattleUnit : MonoBehaviour
{
    protected float maxHP;
    protected float health;
    protected float attack;
    protected float speed;

    protected Animator animator;
    protected Collider target;

    public State state;

    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        state = State.RUN;
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case State.RUN:Move();
                break;
            case State.ATTACK:Attack();
                break;
            case State.DIE:Die();
                break;
        }   
    }

    protected virtual void Move()
    {
       animator.SetBool("Attack", false);
       transform.Translate(-1 * transform.right * speed * Time.deltaTime);
    }

    protected virtual void Attack()
    {
        speed = 0f;
        animator.SetBool("Attack", true);    
    }
    
    protected virtual void Die()
    {
        animator.Play("Die");
        Destroy(gameObject);
    }

    public virtual void Hit(float damage)
    {
        health -= damage;
        if(health<=0)
        {
            state = State.DIE;
        }
    }
    
}
