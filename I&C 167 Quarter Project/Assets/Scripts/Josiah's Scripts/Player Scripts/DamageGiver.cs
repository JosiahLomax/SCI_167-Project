using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageGiver : MonoBehaviour
{
    [SerializeField]
    protected int m_Damage;

    [SerializeField]
    private GameObject parentPrefab;

   
    protected virtual void ApplyDamage(Player player)
    {
        player.ApplyDamage(m_Damage);
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.gameObject.tag == "Player")
        {
            Player player = collison.gameObject.GetComponent<Player>();
            ApplyDamage(player);
            Destroy(this.parentPrefab);
        }
    }
}
