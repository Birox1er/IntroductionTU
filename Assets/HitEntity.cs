using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EntityHealth>())
        {
            other.GetComponent<EntityHealth>().Hit();
        }
        else if (other.GetComponentInParent<EntityHealth>())
        {
            other.GetComponentInParent<EntityHealth>().Hit();
        }
    }
}
