using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellP2 : MonoBehaviour
{
    public Rigidbody2D spellRb;                     // References the rigid body on the Player 2 Spell prefab 
    public float speed = 2.5f;                      // The speed at which the Player 2 Spell moves forward
    public float range = 1;                         // How far the Player 2 Spell travels before being destroyed

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = range;                           // Once the Player 2 spell reaches the end of it's range, another spell should be shot. Meaning it is not rapidly fired
    }

    // Update is called once per frame
    void Update()
    {
        spellRb.velocity = Vector2.left * speed;            // Player 2 spell moves to the left with speed we set

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);                            // The Player 2 spell is destroyed when it hits the end of its range
        }
    }
}
