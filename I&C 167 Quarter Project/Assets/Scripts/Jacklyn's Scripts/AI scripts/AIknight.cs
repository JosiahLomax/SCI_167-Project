using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PARENT CLASS FOR AI ENEMY
public class AIEnemy : MonoBehaviour   // coded by Jacklyn
{
    [SerializeField]
    private Rigidbody2D knightRb;

    [SerializeField]
    private float movementSpeed; 

    private void FixedUpdate()
    { 
        knightRb.velocity = Vector2.left * movementSpeed;
    }

    //[SerializeField]
    //protected GameObject enemyPrefab; // Prefab of the enemy object

    //[SerializeField]
    //protected float movementSpeed;

    //protected virtual void FixedUpdate()
    //{
    //    // Base movement logic for subclasses
    //    //enemyPrefab.velocity = Vector2.left * movementSpeed;
    //}

    //protected void SpawnEnemy()
    //{
    //    // Spawn a new enemy at the position of this GameObject
    //    GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    //    Rigidbody2D enemyRb = newEnemy.GetComponent<Rigidbody2D>();

    //    // Set the velocity of the new enemy to move left
    //    enemyRb.velocity = Vector2.left * movementSpeed;
    //}
}
