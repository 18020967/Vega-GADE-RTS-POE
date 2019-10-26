using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlueBarbarien : MonoBehaviour
{
    string Enemie = "Red Team";
   

    Transform target;
    NavMeshAgent agent;

    public MovementController movement;
    public UnitCombat combat;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<UnitCombat>();
      
    }
    void Update()
    {

        target = movement.FindClosestEnemy(Enemie,"Wizzard").transform;
        agent.SetDestination(target.position);



        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= agent.stoppingDistance)
        {
            UnitStats targetStats = target.GetComponent<UnitStats>();
            if (targetStats != null)
            {
                combat.Attack(targetStats);
            }
        }
     
    }




}
