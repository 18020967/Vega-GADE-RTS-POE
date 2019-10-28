using UnityEngine;

public class SPAWNERS : MonoBehaviour
{ 
    private float spawnTime;


    [SerializeField]
    private GameObject Prefab;
    [SerializeField]
    private float SpawnDelay = 5f;
    public MainUIScript ResourceRemoval;

    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Start()
    {
      
    }

   //basic script for units to spawn on their respected spawners if there are enough resources of that team
   //spawning them next to thespawners
   //this script is used by every spawner 

    private void Spawn()
    {
        if (gameObject.tag == "Wizzard")
        {
            if (ResourceRemoval.greenStored > 200)
            {


                spawnTime = Time.time + SpawnDelay;

                Instantiate(Prefab, transform.position, transform.rotation);


                ResourceRemoval.greenUnitSpawned(200);

            }
        }
        else if (gameObject.tag == "Blue Team")
        {
            if (ResourceRemoval.blueStored > 200)
            {


                spawnTime = Time.time + SpawnDelay;

                Instantiate(Prefab, transform.position+(GameObject.FindWithTag("helper").transform.position), transform.rotation);


                ResourceRemoval.blueUnitSpawned(200);

            }
        }
        else if (gameObject.tag == "Red Team")
        {
            if (ResourceRemoval.redStored > 200)
            {


                spawnTime = Time.time + SpawnDelay;

                Instantiate(Prefab, transform.position, transform.rotation);


                ResourceRemoval.redUnitSpawned(200);

            }
        }
    }

    private bool ShouldSpawn()
    {
        return Time.time >= spawnTime;
    }
}
