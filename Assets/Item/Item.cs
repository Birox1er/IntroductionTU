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
    public EntityHealth health { get { return _entityHealth; } }

    private HealthUI _healthUI;
    public HealthUI healthUI { get { return _healthUI; } }

    protected virtual void Start()
    {
        _goldUI = FindObjectOfType<GoldUI>();
        _healthUI = FindObjectOfType<HealthUI>();

        _col = GetComponent<SphereCollider>();
        if (_col == null) { print("NO COL FIND"); }

    }
    private void OnTriggerEnter(Collider coll)
    {
        if(coll.transform.parent.tag == "Player")
        {
            _gold = FindObjectOfType<EntityGold>();
            _entityHealth = coll.transform.parent.GetComponent<EntityHealth>();
            Action();
        }
        
        Destroy(gameObject);
    }
    protected virtual void Action()
    {
        print(_gold);
        print(_entityHealth);

        print("Is Happening");
    }
}
