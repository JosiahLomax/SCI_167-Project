using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class CastleDetectionP2 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D knightRB;
    [SerializeField]
    private Transform rayCast;
    [SerializeField]
    private float agroRange;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private GameObject enemyCastle;

    private bool canSeePlayer = false;
    private bool facingLeft = true;

    public KnightState knightState;
    public LayerMask enemyPlayer1Layer;



    // Start is called before the first frame update
    void Start()
    {
        knightRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckForPlayer();
    }

    void CheckForPlayer()
    {
        RaycastHit2D hitPlayer = Physics2D.Raycast(rayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, agroRange, enemyPlayer1Layer);

        if(hitPlayer.collider == true)
        {
            Debug.Log("Player Detected!");
            canSeePlayer = true;
            MoveToPlayer();
        }
        else if(hitPlayer.collider != true)
        {
            canSeePlayer = false;
            Debug.Log("Player Not Detected!");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(rayCast.transform.position, (facingLeft ? Vector2.left : Vector2.right) * agroRange);
    }

    public void MoveToPlayer()
    {
        if(canSeePlayer == true)
        {
            if(transform.position.x < enemyCastle.transform.position.x)
            {
                knightRB.velocity = new Vector2(moveSpeed, 0);
            }
            else if(transform.position.x > enemyCastle.transform.position.x)
            {
                knightRB.velocity = new Vector2(-moveSpeed, 0);
            }
        }
    }

    public void StopMoveToPlayer()
    {
        knightRB.velocity = new Vector2(0, 0);
    }
}
