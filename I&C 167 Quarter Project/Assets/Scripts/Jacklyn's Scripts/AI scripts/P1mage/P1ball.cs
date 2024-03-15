using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1ball : MonoBehaviour // made by jacklyn
{
    [SerializeField]
    private Rigidbody2D p1ballRb;

    [SerializeField]
    private float speed = 2.5f;

    [SerializeField]
    private float range = 1;

    [SerializeField]
    private float timer;

    [SerializeField]
    public int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        timer = range;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        p1ballRb.velocity = Vector2.right * speed;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<AIenemyHealth>())
        {
            collision.gameObject.GetComponent<AIenemyHealth>().health -= damage;

        }

    }

}
