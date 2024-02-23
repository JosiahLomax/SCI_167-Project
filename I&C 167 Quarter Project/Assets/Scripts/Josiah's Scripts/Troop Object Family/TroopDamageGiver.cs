using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopDamageGiver : MonoBehaviour
{
    [SerializeField]
    private int Damage;

    [SerializeField]
    private GameObject parentPrefab;
    

    protected virtual void TakeDamage(TroopHealth troop)
    {
        troop.TakeDamage(Damage);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag == "Troop")
        {
            TroopHealth troop = trigger.gameObject.GetComponent<TroopHealth>();
            TakeDamage(troop);
        }
    }


}
