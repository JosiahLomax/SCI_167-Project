using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code Written by Josiah Lomax
public class CastleDetection : MonoBehaviour
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
    [SerializeField]
    private Animator knightAnimator;
   

    private bool canSeePlayer = false;
    private bool facingRight = true;



    public KnightState knightState;
    public LayerMask enemyPlayer2Layer; 
    
    // Start is called before the first frame update
    void Start()
    {
        knightRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForPlayer();
    }

    // Code that Checks for the Enemy's Castle
    void CheckForPlayer()
    {
        RaycastHit2D hitPlayer = Physics2D.Raycast(rayCast.transform.position, facingRight ? Vector2.right : Vector2.left, agroRange, enemyPlayer2Layer);

        if (hitPlayer.collider == true)
        {
            Debug.Log("Player 2 Castle Detected!");
            canSeePlayer = true;
            Invoke("MoveToPlayer", 1);
        }
        else  if (hitPlayer.collider != true)
        {
            canSeePlayer = false;
            Debug.Log("Player 2 Castle Not Detected!");
        }
       
    }

   
 
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(rayCast.transform.position, (facingRight ? Vector2.right : Vector2.left) * agroRange);
    }
  
    


    // Code that Moves the Knight to the Enemy's Castle
    void MoveToPlayer()
    {
        knightState = KnightState.Walking;
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
        Debug.Log("Player 1 Knight is in Walking State!");
    }


    void StopMoveToPlayer()
    {
            knightRB.velocity = new Vector2(0, 0);
    }

}
