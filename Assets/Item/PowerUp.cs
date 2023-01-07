using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : Item
{
    private int amount = 20;
    [SerializeField] UnityEvent _onPickUpMe;

    protected override void Action()
    {
        base.Action();
        _onPickUpMe.Invoke();
        health.AddMaxHealth(amount);
        healthUI.UpdateSlider(health.CurrentHealth, health.maxHealth);
    }
}
