using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    [SerializeField] int _amount = 5;
    
    private GoldUI _ui;
    private EntityGold _entityGold;
    protected override void Start()
    {
        base.Start();
        
    }

    protected override void Action()
    {
        base.Action();
        gold.AddGold(_amount);
        goldUI.UpdateGold(gold.amount);
    }
}
