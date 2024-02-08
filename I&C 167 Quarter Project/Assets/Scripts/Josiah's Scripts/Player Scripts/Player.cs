using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour                                              // Code written by Josiah Lomax
{
    [SerializeField]
    private int m_StartingHealth;                                               // Creates a field within the Unity editor where we can change how much starting health we want


    private int m_MaxHealth;                                                   // The amount of health for the player we want as the max amount possible

    private int m_CurrentHealth;                                              // The current health that is being given to the player



    // Start is called before the first frame update
    void Start()
    {
        m_CurrentHealth = m_StartingHealth;                                  // When the game is started, the player's current health is set as the starting health value
        m_MaxHealth = m_StartingHealth;                                     // Sets the max health value as the starting health value
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyDamage(int damage)                                 // Deals damage to the player; is called in the DamageGiver script
    {
        Debug.Log("Player Damaged! " + damage);                        // Displays the string 'Player Damaged!' within the debug log, followed by the value of damage dealt
        m_CurrentHealth -= damage;                                    // Subtracts the value of damage dealt from the player's current health

        if(m_CurrentHealth <= 0)                                     // If the player's current health is 0 or below, a string will appear in the debug log stating the castle has been sieged
        {
            Debug.Log("Castle Sieged!");
            //Player loses
        }
    }
}
