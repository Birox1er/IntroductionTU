using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _damage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EntityHealth>())
        {
            other.GetComponent<EntityHealth>().Hit(_damage);
        }
        else if (other.GetComponentInParent<EntityHealth>())
        {
            other.GetComponentInParent<EntityHealth>().Hit(_damage);
        }
    }
}
