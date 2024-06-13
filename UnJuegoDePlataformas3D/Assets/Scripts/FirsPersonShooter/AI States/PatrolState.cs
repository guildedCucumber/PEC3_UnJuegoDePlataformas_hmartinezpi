using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : AIEnemyState
{
    enemyAI myEnemy;

    private int nextWayPoint = 0;

    // Cuando llamamos al constructor, guardamos una referencia a la IA de nuestro enemigo
    public PatrolState(enemyAI enemy)
    {
        myEnemy = enemy;
    }

    // Aquí va toda la funcionalidad que queramos que haga el enemigo cuando esté en este estado.
    public void UpdateState()
    {
        // Le decimos al NavMeshAgent cuál es el punto al que ha de dirigirse
        myEnemy.navMeshAgent.destination = myEnemy.wayPoints[nextWayPoint].position;
        Debug.Log("Moving to: " + myEnemy.wayPoints[nextWayPoint].position);

        // Si hemos llegado al destino, cambiamos la referencia al siguiente Waypoint
        if (myEnemy.navMeshAgent.remainingDistance <= myEnemy.navMeshAgent.stoppingDistance)
        {
            nextWayPoint = (nextWayPoint + 1) % myEnemy.wayPoints.Length;
            Debug.Log("Moving to next point");
        }
    }

    // Si el player nos ha disparado
    public void Impact()
    {
        GoToAggroState();
    }

    public void GoToAggroState()
    {
        // Paramos su movimiento
        myEnemy.navMeshAgent.isStopped = true;
        myEnemy.currentState = myEnemy.aggroState;
        Debug.Log("Aggro State");
    }

    // Como ya estamos en el estado Patrol, no llamaremos nunca a esta función desde este estado
    public void GoToPatrolState() { }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            GoToAggroState();
    }

    // En el estado Idle, como el player está fuera del trigger no haremos nada aquí
    public void OnTriggerStay(Collider col) { }
    public void OnTriggerExit(Collider col) { }
}
