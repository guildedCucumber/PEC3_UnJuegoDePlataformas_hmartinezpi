using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AIEnemyState
{
    void UpdateState();
    void GoToAggroState();
    //void GoToAlertState();
    void GoToPatrolState();

    void OnTriggerEnter(Collider col);
    void OnTriggerStay(Collider col);
    void OnTriggerExit(Collider col);

    void Impact();

}