using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1attacking : MonoBehaviour
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
        if (collision.gameObject.GetComponent<TowerHealthAI>())
        {
            collision.gameObject.GetComponent<TowerHealthAI>().health -= damage;

        }

    }
}
