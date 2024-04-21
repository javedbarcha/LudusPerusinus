using System;
using System.Collections;
using System.Collections.Generic;
using Invector;
using UnityEngine;

public class Player : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Stone")
        {
            vDamage damageAmount = new vDamage
            {
                damageValue = col.gameObject.GetComponent<Stone>().damageValue
            };
            vIDamageReceiver receiver = GetComponent<vIDamageReceiver>();
            if (receiver != null)
            {
                receiver.TakeDamage(damageAmount);
                col.gameObject.tag = "Untagged";
            }
        }
    }
}
