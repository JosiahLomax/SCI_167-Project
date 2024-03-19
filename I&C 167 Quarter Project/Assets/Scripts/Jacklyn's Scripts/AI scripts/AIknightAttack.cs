using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// child class of AIEnemy 
public class AIknightAttack : MonoBehaviour // made by jacklyn
{

    [SerializeField]
    private int health;

    [SerializeField]
    private int maxHealth = 1;

    [SerializeField]
    private int damage = 25;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<TowerHealthP1>())
        {
            collision.gameObject.GetComponent<TowerHealthP1>().health -= damage;
            
        }

        if (collision.gameObject.GetComponent<P1enemyHealth>())
        {
            collision.gameObject.GetComponent<P1enemyHealth>().health -= damage;

        }

    }



}
