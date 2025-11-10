using UnityEngine;
using UnityEngine.AI;

public class EnemiAINotEND : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Player != null)
        {
            agent.destination = Player.position;
        }
    }
}

