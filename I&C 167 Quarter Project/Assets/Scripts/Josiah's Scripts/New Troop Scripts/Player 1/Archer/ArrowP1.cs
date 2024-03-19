using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Code Written by Josiah Lomax
public class ArrowP1 : MonoBehaviour
{
    public Rigidbody2D arrowRb;                 // References the rigid body on the Player 1 Arrow prefab 
    public float speed = 2.5f;                  // The speed at which the Player 1 arrow moves forward
    public float range = 1;                    // How far the Player 1 arrow travels before being destroyed

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = range;                      // Once the Player 1 arrow reaches the end of it's range, another arrow should be shot. Meaning it is not rapidly fired
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        arrowRb.velocity = Vector2.right * speed;           // Player 1 arrow moves to the right with speed we set

        timer -= Time.deltaTime;
        if(timer <=0 )
        {
           Destroy(gameObject);                         // The Player 1 arrow is destroyed when it hits the end of its range
        }
    }

    

}
