using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    public int CurrentHealth { get;  private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void Hit()
    {
        CurrentHealth -= 10;

        if (CurrentHealth <= 0)
        {
            Death();
        }

    }

    public void Death()
    { 
        Destroy(gameObject);
    }
}
