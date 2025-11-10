using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitAINotEND : MonoBehaviour
{
    public Transform EnemyTov;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (EnemyTov != null)
        {
            agent.destination = EnemyTov.position;
        }
    }
}
