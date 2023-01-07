using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;

public class HealthPotion : Item
{
    private int amount = 20;
    [SerializeField] UnityEvent _onPickUpMe;

    protected override void Action()
    {
        base.Action();
        _onPickUpMe.Invoke();
        health.AddHealth(amount);
        healthUI.UpdateSlider(health.CurrentHealth, health.maxHealth);
    }
}

