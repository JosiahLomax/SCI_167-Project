using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealthAI : MonoBehaviour
{
    [SerializeField]
    public int health;

    [SerializeField]
    public int maxHealth = 25;

    [SerializeField]
    private Slider slider;

    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
