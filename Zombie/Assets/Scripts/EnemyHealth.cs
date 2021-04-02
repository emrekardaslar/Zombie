using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hp = 100f;
   
    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hp -= damage;
        if (hp <=0)
        {
            Destroy(gameObject);
        }
    }
}
