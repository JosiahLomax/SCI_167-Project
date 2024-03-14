using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    public Rigidbody2D knightRB;
    public int Speed;
   
    void FixedUpdate()
    {
        knightRB.velocity = Vector2.right * Speed;
    }
}
