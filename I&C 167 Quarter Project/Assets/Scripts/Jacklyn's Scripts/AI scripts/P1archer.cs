using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1archer : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D P1archerRb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        P1archerRb.velocity = Vector2.right * speed;
    }
}
