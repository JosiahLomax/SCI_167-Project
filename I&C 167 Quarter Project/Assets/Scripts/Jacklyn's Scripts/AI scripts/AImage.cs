using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AImage : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D AImageRb;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AImageRb.velocity = Vector2.left * speed;
    }
}
