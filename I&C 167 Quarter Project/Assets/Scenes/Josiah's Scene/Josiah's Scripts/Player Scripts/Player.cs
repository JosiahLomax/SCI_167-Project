using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int m_StartingHealth;


    private int m_MaxHealth;

    private int m_CurrentHealth;



    // Start is called before the first frame update
    void Start()
    {
        m_CurrentHealth = m_StartingHealth;
        m_MaxHealth = m_StartingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyDamage(int damage)
    {
        Debug.Log("Player Damaged! " + damage);
        m_CurrentHealth -= damage;

        if(m_CurrentHealth <= 0)
        {
            Debug.Log("Castle Sieged!");
            //Player loses
        }
    }
}
