using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitAINotEND : MonoBehaviour
{
    public Transform EnemyTov;
    private NavMeshAgent agent;
    public float LookRadius = 1f;
    public float speedOB = 2.5f;
    public float speedAT = 4.0f;
    public Transform Enemy;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        Enemy = enemy.transform;
        float distanceEn = Vector3.Distance(transform.position, Enemy.position);

        if (distanceEn <= LookRadius)
        {
            agent.speed = speedAT;
            agent.destination = Enemy.position;
        }

        if (EnemyTov != null && distanceEn > LookRadius)
        {
            agent.speed = speedOB;
            agent.destination = EnemyTov.position; 
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, LookRadius);
    }
}