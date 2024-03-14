using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1arrow : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D p1ArrowRb;

    [SerializeField]
    private float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        p1ArrowRb.velocity = Vector2.right * speed;
    }
}
