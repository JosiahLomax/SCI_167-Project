using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code Written by Josiah Lomax
public class KnightV2 : MonoBehaviour
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
     private GameObject enemyTroop;


    private bool canSeePlayer = false;
    private bool canSeeTroop = false;
    private bool facingRight = true;

   

    
    public LayerMask enemyPlayer2Layer, enemyTroopLayerP2;
    
    // Start is called before the first frame update
    void Start()
    {
        knightRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForPlayer();
        CheckForTroop();
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
        else
        {
            canSeePlayer = false;
            Debug.Log("Player Not Detected!");
            StopMoveToPlayer();
        }
       
    }

   IEnumerator PlayerDetected()
    {
        yield return new WaitForSeconds(2);
        MoveToPlayer();
    }
  


    // Code that Checks for the Enemy's Troop
    void CheckForTroop()
    {
        RaycastHit2D hitTroop = Physics2D.Raycast(rayCast.transform.position, facingRight ? Vector2.right : Vector2.left, agroRange, enemyTroopLayerP2);

        if (hitTroop.collider == true)
        {
            canSeeTroop = true;
            Debug.Log("Troop Detected!");
            StartCoroutine(TroopDetected());
        }
        else
        {
            canSeeTroop = false;
            Debug.Log("Troop Not Detected!");
            StopMoveToTroop();
        }
    }

    IEnumerator TroopDetected()
    {
        yield return new WaitForSeconds(2);
        MoveToTroop();
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
        if (canSeePlayer == false)
        {
            knightRB.velocity = new Vector2(0, 0);
           // Debug.Log("Player Not Detected!");
        }
    }



    // Code that moves the Knight to the Enemy's Troop
    void MoveToTroop()
    {
        if(canSeeTroop == true)
        {
            if(transform.position.x < enemyTroop.transform.position.x)
            {
                knightRB.velocity = new Vector2(moveSpeed, 0);
            }
            else if( transform.position.x > enemyTroop.transform.position.x)
            {
                knightRB.velocity = new Vector2(-moveSpeed, 0);
            }
        }
    }

    void StopMoveToTroop()
    {
        if(canSeeTroop == false)
        {
            knightRB.velocity = new Vector2(0, 0);
        }
    }
   
}
