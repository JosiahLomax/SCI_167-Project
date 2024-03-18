using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIshielder : MonoBehaviour //made by jacklyn
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D AIshielderRb;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AIshielderRb.velocity = Vector2.right * speed;
    }
}

