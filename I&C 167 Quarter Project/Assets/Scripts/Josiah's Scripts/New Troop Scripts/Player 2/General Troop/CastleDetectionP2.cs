using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class CastleDetectionP2 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D knightRB;                                // References the rigid body on the Player 2 troop prefab
    [SerializeField]
    private Transform rayCast;                                   // References the ray cast object on the Player 2 troop prefab
    [SerializeField]
    private float agroRange;                                    // The range that determines how far the Player 2 troop can see
    [SerializeField]
    private float moveSpeed;                                    // How fast the Player 2 troop moves 
    [SerializeField]
    private GameObject enemyCastle;                             // References the prefab for the enemy player's castle

    private bool canSeePlayer = false;
    private bool facingLeft = true;

    public KnightState knightState;
    public LayerMask enemyPlayer1Layer;                         // enemyTroopLayerP1 is the layer that the player 1 castle prefab should be under



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
        RaycastHit2D hitPlayer = Physics2D.Raycast(rayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, agroRange, enemyPlayer1Layer);                 // Creates a raycast at the point of the raycast object on the Player 2 troop prefab, with the length of the agro range. It looks for anything on the enemyPlayer1Layer

        if (hitPlayer.collider == true)                       // If the raycast successfully hits anything on the enemyPlayer1Layer, it performs the following functions
        {
            Debug.Log("Player 1 Castle Detected!");
            canSeePlayer = true;
            Invoke("MoveToPlayer", 1);                           // Invoke acts as a timer so that the Player 2 troop does not immediatley begin moving as soon as it spawns in. It should instead wait 1 sec
        }
        else if(hitPlayer.collider != true)                        // If the raycast does not hit anything on the enemyTroopLayerP1, it performs the following functions
        {
            canSeePlayer = false;
            Debug.Log("Player 1 Castle Not Detected!");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(rayCast.transform.position, (facingLeft ? Vector2.left : Vector2.right) * agroRange);
    }

    public void MoveToPlayer()
    {
        knightState = KnightState.Walking;                  // (If the troop is a knight) Calls the Knight State Machine script, and sets the Knight's state to walking
        if (canSeePlayer == true)
        {
            if(transform.position.x < enemyCastle.transform.position.x)          // If the position of the Player 2 troop prefab is to the right of the enemy troop, the Player 2 troop will move to the left
            {
                knightRB.velocity = new Vector2(moveSpeed, 0);
            }
            else if(transform.position.x > enemyCastle.transform.position.x)    // If the position of the Player 2 troop prefab is to the left of the enemy troop, the Player 2 troop will move to the right
            {
                knightRB.velocity = new Vector2(-moveSpeed, 0);
            }
        }
        Debug.Log("Player 2 Knight is in Walking State!");
    }

    public void StopMoveToPlayer()
    {
        knightRB.velocity = new Vector2(0, 0);                       // Brings the velocity of the Player 2 troop prefab to 0, meaning it stops moving
    }

}
