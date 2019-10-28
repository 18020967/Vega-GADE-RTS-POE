using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(UnitStats))]
public class UnitCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCooldown = 0f;

    public UnitStats myStats;

    private void Start()
    {
        myStats = GetComponent<UnitStats>();
    }

    private void Update()
    {
        //helping that the unit can only attack every second
        attackCooldown -= Time.deltaTime;
    }

    public void Attack (UnitStats targetStats)
    {

        //fighting the unit by getting own stats from stats class and getting stats from enemy stats class
        if (attackCooldown <= 0f)
        {
            targetStats.TakeDamage(myStats.damage.GetValue());
            attackCooldown = 1f / attackSpeed;
            
        }
        
    }
}
