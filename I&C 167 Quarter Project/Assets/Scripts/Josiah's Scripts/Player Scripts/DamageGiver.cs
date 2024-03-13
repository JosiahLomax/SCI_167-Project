using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageGiver : MonoBehaviour                                //Code written by Josiah Lomax
{
    [SerializeField]
    private int m_Damage;                                               // Creates a field that allows us to change how much damage is given

    [SerializeField]
    private GameObject parentPrefab;                                    // A field in which we can plug the parent prefab object into, to be refreneced 

   
    protected virtual void ApplyDamage(Player player)
    {
        player.ApplyDamage(m_Damage);                                   // References the Player class which hold the health, and applies damage to it.
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.gameObject.tag == "Player")                         // If the damage giver object collides with a gameObject tagged 'player' it will call the ApplyDamage function
        {
            Player player = collison.gameObject.GetComponent<Player>(); // Gets the Player component from the object collided with
            ApplyDamage(player);
            Destroy(this.parentPrefab);                                 //Once the parent prefab collides with the object tagged 'player' it will be destroyed
        }
    }
}
