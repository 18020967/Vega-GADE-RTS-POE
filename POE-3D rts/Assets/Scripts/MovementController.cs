using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{

  public GameObject FindClosestEnemy(string team,string team2)
  {
        GameObject closest = null;


        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(team);
        GameObject closest0 = null;
        float distance = Mathf.Infinity;
        Vector3 position = this.transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if(curDistance< distance)
            {
                closest0 = go;
                distance = curDistance;
            }
          
        }

        GameObject[] gos1;
        gos1 = GameObject.FindGameObjectsWithTag(team2);
        GameObject closest1 = null;
        float distance1 = Mathf.Infinity;
        Vector3 position1 = this.transform.position;
        foreach (GameObject go1 in gos1)
        {
            Vector3 diff1 = go1.transform.position - position;
            float curDistance = diff1.sqrMagnitude;
            if (curDistance < distance1)
            {
                closest1 = go1;
                distance1 = curDistance;
            }

        }

        if (distance < distance1)
        {
            closest = closest0;
        }
        else
        {
            closest = closest1;
        }



        return closest;



  }


}
