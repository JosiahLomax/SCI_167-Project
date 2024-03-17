using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIball : MonoBehaviour //made by jacklyn
{
    [SerializeField]
    private Rigidbody2D AIballRb;

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
        AIballRb.velocity = Vector2.left * speed;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<P1enemyHealth>())
        {
            collision.gameObject.GetComponent<P1enemyHealth>().health -= damage;

        }

    }
}
