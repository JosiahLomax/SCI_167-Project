using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1goblin : MonoBehaviour // made by jacklyn
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D P1goblinRb;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        P1goblinRb.velocity = Vector2.right * speed;
    }
}
