using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SimpleNavMeshAgent : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; // Disables automatic rotation
    }
    private void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
