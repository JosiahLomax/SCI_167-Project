using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowP2 : MonoBehaviour
{
    public Rigidbody2D arrowRb;
    public float speed = 2.5f;
    public float range = 1;
    //  public int damage = 10;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = range;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        arrowRb.velocity = Vector2.left * speed;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
