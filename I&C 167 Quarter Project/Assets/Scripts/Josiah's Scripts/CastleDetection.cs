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
            canSeePlayer = true;
            Debug.Log("Player Detected!");
            StartCoroutine(PlayerDetected()); 
        }
        else  if (hitPlayer.collider != true)
        {
            canSeePlayer = false;
            StopMoveToPlayer();
        }
       
    }

   IEnumerator PlayerDetected()
    {
        if (canSeePlayer == true)
        {
            yield return new WaitForSeconds(2);
            knightState = KnightState.Walking;
            Debug.Log("Knight is in the Walking State!");
            MoveToPlayer();
        }
    }
  


   
 
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(rayCast.transform.position, (facingRight ? Vector2.right : Vector2.left) * agroRange);
    }
  
    


    // Code that Moves the Knight to the Enemy's Castle
    void MoveToPlayer()
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


    void StopMoveToPlayer()
    {
            knightRB.velocity = new Vector2(0, 0);
            Debug.Log("Player Not Detected!");
    }

}
