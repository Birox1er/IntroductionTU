using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    private int amount = 20;
    protected override void Action()
    {
        base.Action();
        health.AddMaxHealth(amount);
        healthUI.UpdateSlider(health.CurrentHealth, health.maxHealth);
    }
}
