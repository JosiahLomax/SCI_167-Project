using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// child class of AIEnemy 
public class AIknight : MonoBehaviour
{

    [SerializeField]
    private int health;

    [SerializeField]
    private int maxHealth = 1;

    [SerializeField]
    private int damage = 1;

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
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.GetComponent<DamageGiver>().)
    //    {

    //    }
    //}


}
