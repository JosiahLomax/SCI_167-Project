using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class TroopHealth : MonoBehaviour
{
    [SerializeField]
    private int StartingHealth;

    private int MaxHealth;
    public int CurrentHealth;
    

   
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = StartingHealth;
        MaxHealth = StartingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Troop has " + CurrentHealth + " health!");
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


    public void TakeDamage(int damage)
    {
        Debug.Log("Troop Damaged! " + damage);
        CurrentHealth -= damage;
    }
}
