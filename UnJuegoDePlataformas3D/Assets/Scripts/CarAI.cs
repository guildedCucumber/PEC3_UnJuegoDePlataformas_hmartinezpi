using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarAI : MonoBehaviour
{
    [HideInInspector] public NavMeshAgent navMeshAgent;

    public Transform[] wayPoints;
    private int nextWayPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = wayPoints[nextWayPoint].position;

        // Si hemos llegado al destino, cambiamos la referencia al siguiente Waypoint
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            nextWayPoint = (nextWayPoint + 1) % wayPoints.Length;
            Debug.Log("Moving to next point");
        }
    }
}
