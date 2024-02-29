using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    public Rigidbody2D knightRB;
    public int Speed;
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        knightRB.velocity = Vector2.right * Speed;
    }
}
