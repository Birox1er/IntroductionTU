using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private SphereCollider _col;
    
    private EntityGold _gold;
    public EntityGold gold { get { return _gold; } }
    private GoldUI _goldUI;
    public GoldUI goldUI { get { return _goldUI; } }

    private EntityHealth _entityHealth;
    private HealthUI _healthUI;

    protected virtual void Start()
    {
        _goldUI = FindObjectOfType<GoldUI>();
        _col = GetComponent<SphereCollider>();
        if (_col == null) { print("NO COL FIND"); }

    }
    private void OnTriggerEnter(Collider coll)
    {
        if(coll.transform.parent.tag == "Player")
        {
            _gold = FindObjectOfType<EntityGold>();
            _entityHealth = coll.gameObject.GetComponent<EntityHealth>();
            _healthUI = coll.gameObject.GetComponent<HealthUI>();
            Action();
        }
        
        Destroy(gameObject);
    }
    protected virtual void Action()
    {
        print(_gold);
        print("Is Happening");
    }
}
