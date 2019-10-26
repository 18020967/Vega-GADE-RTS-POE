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
        attackCooldown -= Time.deltaTime;
    }

    public void Attack (UnitStats targetStats)
    {
        if (attackCooldown <= 0f)
        {
            targetStats.TakeDamage(myStats.damage.GetValue());
            attackCooldown = 1f / attackSpeed;
        }
        
    }
}
