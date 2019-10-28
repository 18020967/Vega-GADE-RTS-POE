using UnityEngine;

public class UnitStats : MonoBehaviour
{
    public Stat damage;
    public int maxHealth = 100;
    public int currenthealth { get; private set; }
    //this is mostly used for when combat happens
    private void Awake()
    {
        currenthealth = maxHealth;
    }

    public void TakeDamage(int Damage)
    {
        currenthealth -= Damage;
        Debug.Log(transform.name + " takes " + damage + " Damage.");

        if (currenthealth <= 0)
        {
            Destroy(gameObject);

        }
    }
}
