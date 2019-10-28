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

        //this code makes sure that this game object always targets the enemie closest to it
        //we do this by using the find closest enemy with tag function since there are 3 teams and 3 tags
        target = movement.FindClosestEnemy(Enemie, "Wizzard").transform;
        agent.SetDestination(target.position);
        Debug.DrawLine(gameObject.transform.position, target.transform.position, Color.grey);
        //drawing a line betwen the game object and its target to see in the debug scene

        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= agent.stoppingDistance)
        {
            //when the unit should start attaking is when the target is in range
            UnitStats targetStats = target.GetComponent<UnitStats>();
            if (targetStats != null)
            {
                combat.Attack(targetStats);
                Debug.DrawLine(gameObject.transform.position, target.transform.position, Color.red);
            }
        }

    }



}
