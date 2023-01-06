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
    [SerializeField] UnityEvent _onHeal;
    [SerializeField] UnityEvent _onHealthUp;
    [SerializeField] UnityEvent _onDmgTaken;
    [SerializeField] UnityEvent _onDeath;
    [SerializeField] HealthUI _healthUI;
    public int maxHealth { get { return _maxHealth; } }
    public int CurrentHealth { get;  private set; }


    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    IEnumerator animDmg()
    {
        OnStartDamage?.Invoke();
        yield return new WaitForSeconds(1);
        OnStopDamage?.Invoke();
    }
    public void AddHealth(int amount)
    {
        CurrentHealth += amount;
        _onHeal.Invoke();
        
        if (CurrentHealth > _maxHealth)
        {
            CurrentHealth = _maxHealth;
        }
    }
    
    public void AddMaxHealth(int amount)
    {
        _maxHealth += amount;
        _onHealthUp.Invoke();
        if (_maxHealth < 50)
        {
            _maxHealth = 50;
            if(CurrentHealth > _maxHealth)
            {
                CurrentHealth = _maxHealth;
            }
        }
        if (amount > 0)
        {
            AddHealth(amount);
        }
        else
        {
            _healthUI.UpdateSlider(CurrentHealth, _maxHealth);
        }
    }
    public void Hit(int damage)
    {
        OnStopDamage?.Invoke();
        CurrentHealth -= damage;
        StartCoroutine(animDmg());
        if (CurrentHealth <= 0)
        {
            Death();
        }
        if (_healthUI)
        {
            _healthUI.UpdateSlider(CurrentHealth, _maxHealth);
            _onDmgTaken.Invoke();
        }
    }

    public void Death()
    { 
        Destroy(gameObject);
    }
}
