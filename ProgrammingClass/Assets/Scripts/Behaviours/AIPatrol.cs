using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPatrol : MonoBehaviour
{
    private NavMeshAgent agent;
    public List<Vector3> patrolPoints;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        agent = GetComponent<NavMeshAgent>();
    }

    private int i = 0;
    
    void Update()
    {
        if (agent.pathPending || !(agent.remainingDistance < 0.5f)) return;
        agent.destination = patrolPoints[i].position;
        i = (i + 1) % patrolPoints.Count;
    }
}
