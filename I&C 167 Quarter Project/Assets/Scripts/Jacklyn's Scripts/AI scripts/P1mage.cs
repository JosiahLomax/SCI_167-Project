using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1mage : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D P1mageRb;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        P1mageRb.velocity = Vector2.right * speed;
    }
}
