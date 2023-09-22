using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float speed = 1.0f;
    [SerializeField] float dir = 1.0f;
    bool attak = false;
    bool dead = false;
    [SerializeField]int hp = 5;
    [SerializeField]P enemy;

    // Start is called before the first frame update
    void Start()
    {
        direction.z = dir;
        gameObject.transform.Rotate(0, 90 * dir, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            Destroy(gameObject);
        }
        transform.Translate(direction * speed * Time.deltaTime);
        if(attak)
        {
            gameObject.GetComponent<Animator>().Play("Attack");
            attak = false;
        }
        if(hp <= 0)
        {
            gameObject.transform.Translate(0,0,-100);
            dead = true;
        }
    }

    public void Attack(int damage)
    {
        enemy.Damaged(damage);
    }

    public void Damaged(int damage)
    {
        hp -= damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = 0f;
        enemy = other.GetComponent<P>();
    }

    private void OnTriggerStay(Collider other)
    {
        attak = true;
    }

    private void OnTriggerExit(Collider other)
    {
        speed = 1.0f;
        enemy = null;
    }

}
