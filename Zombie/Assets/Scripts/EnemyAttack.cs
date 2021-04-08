using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;
    private void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        if (Vector3.Distance(transform.position, target.transform.position) < 2)
        {
            target.TakeDamage(damage);
            target.GetComponent<DisplayDamage>().ShowDamageImpact();
        }
    }
}
