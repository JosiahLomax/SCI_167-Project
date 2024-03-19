using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1enemyHealth : MonoBehaviour
{
    [SerializeField]
    public int health;

    [SerializeField]
    public int maxHealth = 25;


    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
