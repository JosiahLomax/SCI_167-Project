using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIgoblin : MonoBehaviour //made by jacklyn
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D AIgoblinRb;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AIgoblinRb.velocity = Vector2.right * speed;
    }
}
