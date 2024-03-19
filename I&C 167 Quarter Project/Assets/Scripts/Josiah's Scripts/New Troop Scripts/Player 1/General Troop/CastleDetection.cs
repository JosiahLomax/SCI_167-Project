using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code Written by Josiah Lomax
public class CastleDetection : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D knightRB;                   // References the rigid body on the Player 1 troop prefab
    [SerializeField]
    private Transform rayCast;                     // References the ray cast object on the Player 1 troop prefab
    [SerializeField]
    private float agroRange;                      // The range that determines how far the Player 1 troop can see
    [SerializeField]
    private float moveSpeed;                      // How fast the Player 1 troop moves 
    [SerializeField]
    private GameObject enemyCastle;             // References the prefab for the enemy player's castle
    [SerializeField]
    private Animator knightAnimator;            // References the animator for the Player 1 troop
   

    private bool canSeePlayer = false;
    private bool facingRight = true;



    public KnightState knightState;             // References the P1Knight State Machine script
    public LayerMask enemyPlayer2Layer;         // enemyTroopLayerP2 is the layer that the player 2 castle prefab should be under

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
        RaycastHit2D hitPlayer = Physics2D.Raycast(rayCast.transform.position, facingRight ? Vector2.right : Vector2.left, agroRange, enemyPlayer2Layer);           // Creates a raycast at the point of the raycast object on the Player 1troop prefab, with the length of the agro range. It looks for anything on the enemyPlayer2Layer

        if (hitPlayer.collider == true)                                     // If the raycast successfully hits anything on the enemyPlayer2Layer, it performs the following functions
        {
            Debug.Log("Player 2 Castle Detected!");
            canSeePlayer = true;
            Invoke("MoveToPlayer", 1);                                     // Invoke acts as a timer so that the Player 1 troop does not immediatley begin moving as soon as it spawns in. It should instead wait 1 sec
        }
        else  if (hitPlayer.collider != true)                              // If the raycast does not hit anything on the enemyTroopLayerP2, it performs the following functions
        {
            canSeePlayer = false;
            Debug.Log("Player 2 Castle Not Detected!");
        }
       
    }

   
 
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(rayCast.transform.position, (facingRight ? Vector2.right : Vector2.left) * agroRange);               // Just creates a line within the editor so the length of the raycast is visible
    }
  
    


    // Code that Moves the Knight to the Enemy's Castle
    public void MoveToPlayer()
    {
        knightState = KnightState.Walking;                              // (If the troop is a knight) Calls the Knight State Machine script, and sets the Knight's state to walking
       if(canSeePlayer == true)
       {
            if(transform.position.x < enemyCastle.transform.position.x)             // If the position of the Player 1 troop prefab is to the left of the enemy troop, the troop will move to the right
            {
                knightRB.velocity = new Vector2(moveSpeed, 0);
            }
            else if(transform.position.x > enemyCastle.transform.position.x)        // If the position of the Player 1 troop prefab is to the right of the enemy troop, the troop will move to the left
            {
                knightRB.velocity = new Vector2(-moveSpeed, 0);
            }
       }
        Debug.Log("Player 1 Knight is in Walking State!");
    }


    public void StopMoveToPlayer()
    {
            knightRB.velocity = new Vector2(0, 0);               // Brings the velocity of the Player 1 troop prefab to 0, meaning it stops moving
    }

}
