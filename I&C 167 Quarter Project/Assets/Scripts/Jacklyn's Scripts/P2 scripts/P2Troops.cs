using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// P2 PARENT CLASS - made by Jacklyn
public class P2Troops : MonoBehaviour
{
    public Transform P1target; //target for p2 will be p1's troops/tower
    //public float P2movementSpeed; //used for all types of troops
    public int damage;


    protected virtual void Start()
    {
        //P2MoveTowardTarget();
    }

    protected virtual void Update()
    {
        P2MoveTowardTarget();
    }

    protected virtual void P2MoveTowardTarget()
    {
        
    }
    //protected virtual void ApplyDamage(Player player, int damage)
    //{
    //    player.ApplyDamage(damage);
    //}

    //private void OnTriggerEnter2D(Collider2D collison)
    //{
    //    if (collison.gameObject.CompareTag("Player"))
    //    {
    //        Player player = collison.gameObject.GetComponent<Player>();
    //        ApplyDamage(player, damage); // Apply damage with a specific amount
    //        Destroy(this.gameObject);   // Destroy the object that collided with the player
    //    }
    //}

}
