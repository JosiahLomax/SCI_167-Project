using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PARENT CLASS FOR AI ENEMY
public class AIEnemy : MonoBehaviour   // coded by Jacklyn
{
    [SerializeField]
    private Rigidbody2D knightRb;

    [SerializeField]
    private Rigidbody2D archerRb;

    [SerializeField]
    private float movementSpeed; //used for all types of troops

    private void FixedUpdate()
    {
        knightRb.velocity = Vector2.left * movementSpeed;
        archerRb.velocity = Vector2.left * movementSpeed;
    }
}
