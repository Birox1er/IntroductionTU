using Cinemachine;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EntityHealth : MonoBehaviour
{
    public event Action OnStartDamage;
    public event Action OnStopDamage;

    [SerializeField] int _maxHealth;
    [SerializeField] UnityEvent _onEvent;
    [SerializeField] UnityEvent _onEventPost;

    public int maxHealth { get { return _maxHealth; } }
    public int CurrentHealth { get;  private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }
    public void AddHealth(int amount)
    {
        CurrentHealth += amount;
        
        if (CurrentHealth > _maxHealth)
        {
            CurrentHealth = _maxHealth;
        }
    }
    public void Hit()
    {
        CurrentHealth -= 10;
        OnStartDamage?.Invoke();
        if (CurrentHealth <= 0)
        {
            Death();
        }
        OnStopDamage?.Invoke();
    }

    public void Death()
    { 
        Destroy(gameObject);
    }
}
