using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    public int touche { get; private set; }
    private EntityHealth entity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EntityHealth>())
        {
            other.GetComponent<EntityHealth>().Hit();
        }
    }
}
