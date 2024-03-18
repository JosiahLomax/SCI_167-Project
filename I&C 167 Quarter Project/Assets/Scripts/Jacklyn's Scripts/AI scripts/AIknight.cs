using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIknight : MonoBehaviour   // coded by Jacklyn
{
    [SerializeField]
    private Rigidbody2D knightRb;

    [SerializeField]
    private float movementSpeed; 

    private void FixedUpdate()
    { 
        knightRb.velocity = Vector2.left * movementSpeed;
    }

    
}
