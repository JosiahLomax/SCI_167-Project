using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1shielder : MonoBehaviour //made by jacklyn
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D P1shielderRb;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        P1shielderRb.velocity = Vector2.left * speed;
    }
}
