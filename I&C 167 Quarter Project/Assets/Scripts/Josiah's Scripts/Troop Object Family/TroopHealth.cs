using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class TroopHealth : MonoBehaviour
{

    [SerializeField]
    private int startingHealth;

    [SerializeField]
    private int maxHealth;

    [SerializeField]
    private GameObject parentPrefab;

    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        maxHealth = startingHealth;
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log("Enemy Troop Damaged");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this.parentPrefab);

        Debug.Log("Enemy Troop has Died!");
    }

}
