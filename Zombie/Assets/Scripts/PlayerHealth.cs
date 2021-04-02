﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hp = 100f;
    
    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
