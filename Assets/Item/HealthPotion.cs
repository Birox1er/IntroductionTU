using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class HealthPotion : Item
{
    private int amount = 20;
    protected override void Action()
    {
        base.Action();
        health.AddHealth(amount);
        healthUI.UpdateSlider(health.CurrentHealth, health.maxHealth);
    }
}

