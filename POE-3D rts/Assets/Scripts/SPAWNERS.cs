using UnityEngine;

public class SPAWNERS : MonoBehaviour
{ 
    private float spawnTime;


[SerializeField]
private GameObject Prefab;
[SerializeField]
private float SpawnDelay = 5f;

void Update()
{
    if (ShouldSpawn())
    {
        Spawn();
    }
}

private void Spawn()
{
    spawnTime = Time.time + SpawnDelay;

    Instantiate(Prefab, transform.position, transform.rotation);




}

private bool ShouldSpawn()
{
    return Time.time >= spawnTime;
}
}
