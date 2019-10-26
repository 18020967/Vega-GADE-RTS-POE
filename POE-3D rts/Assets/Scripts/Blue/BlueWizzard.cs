using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlueWizzard : MonoBehaviour
{
    string Enemie = "Red Team";

    Transform target;
    NavMeshAgent agent;


    [SerializeField]
    private GameObject Prefab;

    public MovementController movement;
    public UnitCombat combat;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<UnitCombat>();


    }
    static public Vector3 pos;
    private float spawnTime;
    private float SpawnDelay = 2f;
    void Update()
    {


        target = movement.FindClosestEnemy("Wizzard", Enemie).transform;
        agent.SetDestination(target.position);



        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= agent.stoppingDistance)
        {
            if (ShouldSpawn())
            {
                Spawn();
            }


        }

    }
    private void Spawn()
    {
        spawnTime = Time.time + SpawnDelay;
        Instantiate(Prefab, transform.position, transform.rotation);
        onMageAttack();

    }
    private bool ShouldSpawn()
    {
        return Time.time >= spawnTime;
    }


    float blastradius = 4f;
    GameObject[] EnemiesBlue;
    GameObject[] EnemiesRed;
    void onMageAttack()
    {
        EnemiesBlue = GameObject.FindGameObjectsWithTag(Enemie);
        foreach (GameObject enemie in EnemiesBlue)
        {
            UnitStats targetStats = enemie.GetComponent<UnitStats>();
            if (blastradius >= Vector3.Distance(transform.position, enemie.transform.position))
            {
                combat.Attack(targetStats);
            }
        }

        EnemiesRed = GameObject.FindGameObjectsWithTag("Red Team");
        foreach (GameObject enemie in EnemiesRed)
        {
            UnitStats targetStats = enemie.GetComponent<UnitStats>();
            if (blastradius >= Vector3.Distance(transform.position, enemie.transform.position))
            {
                combat.Attack(targetStats);
            }
        }
    }





}