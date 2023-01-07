using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gold : Item
{
    [SerializeField] int _amount = 5;
    [SerializeField] UnityEvent _onPickUpMe;

    private GoldUI _ui;
    private EntityGold _entityGold;
    protected override void Start()
    {
        base.Start();
        
    }

    protected override void Action()
    {
        base.Action();
        _onPickUpMe.Invoke();
        gold.AddGold(_amount);
        goldUI.UpdateGold(gold.amount);
    }
}
