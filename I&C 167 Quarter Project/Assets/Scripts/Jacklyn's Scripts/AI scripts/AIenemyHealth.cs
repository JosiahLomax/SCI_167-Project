using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIenemyHealth : MonoBehaviour // made by jacklyn
{
    // script being used for all AIenemies

    [SerializeField]
    public int health;

    [SerializeField]
    public int maxHealth;


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
