using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AttackArea : MonoBehaviour
{
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
       if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
    }



}
