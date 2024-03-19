using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIarcher : MonoBehaviour // made by jacklyn
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D AIarcherRb;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AIarcherRb.velocity = Vector2.left * speed;
    }
}

