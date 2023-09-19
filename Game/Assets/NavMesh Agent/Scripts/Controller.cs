using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public int count;
    public Transform[] point;
    public NavMeshAgent navMeshAgent;
    
    void Start()
    {        InvokeRepeating("Move", 1, 5f);
    }

    private void Move()
    {
        if(navMeshAgent.velocity == Vector3.zero)
        {
            if(point.Length<=count)
            {
                count = 0;
            }
        }
        navMeshAgent.SetDestination(point[count++].position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            navMeshAgent.SetDestination(other.transform.position);
        }
    }
}
