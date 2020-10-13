using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    public bool noPursuit = true;
    public bool patrol = true;
    private WaitForFixedUpdate wffu;
    public float holdTime = 1f;
    private WaitForSeconds wfs;
    public List<Transform> patrolPoints;

    private void Start()
    {
        i = 0;
        agent = GetComponent<NavMeshAgent>();
        wfs = new WaitForSeconds(holdTime);
    }
    private int i = 0;

    private void Update()
    {
        if (patrol == true)
        {
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) return;
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }

    private IEnumerator Navigate()
    {
        noPursuit = true;
        while (noPursuit == false)
        {
            yield return wffu;
            agent.destination = player.position;
        }
        patrol = true;
        yield return new WaitForSeconds(0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            patrol = false;
            noPursuit = false;
            StartCoroutine(Navigate());
        }
    }

}
