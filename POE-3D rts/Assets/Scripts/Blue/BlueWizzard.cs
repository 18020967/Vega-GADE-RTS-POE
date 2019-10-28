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

        //this code makes sure that this game object always targets the enemie closest to it
        //we do this by using the find closest enemy with tag function since there are 3 teams and 3 tags
        target = movement.FindClosestEnemy("Wizzard", Enemie).transform;
        agent.SetDestination(target.position);
        //drawing a line betwen the game object and its target to see in the debug scene
        Debug.DrawLine(gameObject.transform.position, target.transform.position, Color.grey);

        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= agent.stoppingDistance)
        {
            //when the unit should start attaking is when the target is in range
            if (ShouldSpawn())
            {
                Spawn();
            }


        }

    }
    private void Spawn()
    {
        //spawns the visuals of the AOE attack of the wizzard
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
        //here the mage finds it target that it wants to attack , 2 sets of code that are compared to eachther 
        //beacuse there are two other team tags to consider
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