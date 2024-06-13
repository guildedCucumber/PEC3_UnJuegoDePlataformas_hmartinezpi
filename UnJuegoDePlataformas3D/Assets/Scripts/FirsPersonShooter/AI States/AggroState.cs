using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroState : AIEnemyState
{
    enemyAI myEnemy;

    private float actualTimeBetweenAttacks = 0;

    // Cuando llamamos al constructor, guardamos una referencia a la IA de nuestro enemigo
    public AggroState (enemyAI enemy)
    {
        myEnemy = enemy;
    }

    // Aquí va toda la funcionalidad que queramos que haga el enemigo cuando esté en este estado.
    public void UpdateState()
    {
        actualTimeBetweenAttacks += Time.deltaTime;
    }

    // Si el player nos ha disparado no haremos nada
    public void Impact() { }

    // Como ya estamos en el estado Aggro, no llamaremos nunca a estas funciones desde este estado
    public void GoToAggroState() { }
    public void GoToPatrolState() 
    {
        myEnemy.currentState = myEnemy.patrolState;
    }

    // El player ya está en nuestro trigger
    public void OnTriggerEnter(Collider col) { }

    // Orientamos al enemigo mirando siempre al player mientras le ataquemos
    public void OnTriggerStay(Collider col)
    {
        // Estaremos mirando siempre al player
        Vector3 lookDirection = col.transform.position - myEnemy.transform.position;

        // Le toca volver a atacar
        if (actualTimeBetweenAttacks > myEnemy.timeBetweenAttacks)
        {
            // Rotamos en el eje Y
            myEnemy.transform.rotation = Quaternion.FromToRotation(Vector3.forward, new Vector3(lookDirection.x, 0, lookDirection.z));
            //myEnemy.transform.position = myEnemy.transform.position + lookDirection;
            myEnemy.navMeshAgent.SetDestination(lookDirection);
            Debug.Log("Moving to: " + lookDirection);

            myEnemy.anim.SetTrigger("Attack");

            actualTimeBetweenAttacks = 0;
            col.gameObject.GetComponent<ShieldSystem>().TakeDamage(myEnemy.damageForce);
            Debug.Log("Player hit: " + myEnemy.damageForce);
        }
    }

    // Si el player sale de su radio, pasa a modo Patrol
    public void OnTriggerExit(Collider col)
    {
        GoToPatrolState();
    }
}