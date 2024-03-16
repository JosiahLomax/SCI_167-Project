using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class TroopDetectionP2 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D troopRB;                         // A reference to the Player 2 troop's rigid body
    [SerializeField]
    private Transform rayCast;                          // A reference to the raycast object on the Player 2 troop's prefab
    [SerializeField]
    private float agroRange;                            // How far the Player 2 troop can see
    [SerializeField]
    private float moveSpeed;                            // How fast the Player 2 troop moves
    [SerializeField]
    private GameObject enemyTroop;

    private bool canSeeTroop = false;
    private bool facingLeft = true;

    public LayerMask enemyTroopLayerP1;                 // The layer that all player 1 troops should be under
    public KnightState knightState;                    // A reference to the Knightstate Script

    // Start is called before the first frame update
    void Start()
    {
        troopRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       CheckForTroop();
    }


    void CheckForTroop()
    {
        RaycastHit2D hitTroop = Physics2D.Raycast(rayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, agroRange, enemyTroopLayerP1);                   // Creates a raycast at the point of the raycast object on the Player 2 troop prefab, with the length of the agro range. It looks for anything on the enemyTroopLayerP1 layer

        if (hitTroop.collider == true)                                  // If the raycast successfully hits anything on the enemyTroopLayerP1, it performs the following functions
        {
            Debug.Log("Player 1 Troop Detected!");
            canSeeTroop = true;
            Invoke("MoveToTroop", 1);                                    // Invoke acts as a timer so that the Player 2 troop does not immediatley begin moving as soon as it spawns in. It should instead wait 1 sec
        }
        else if(hitTroop.collider != true)                               // If the raycast does not hit anything on the enemyTroopLayerP1, it performs the following functions
        {
            Debug.Log("Player 1 Troop Not Detected!");
            canSeeTroop = false;
        }
    }

    public void MoveToTroop()
    {
        knightState = KnightState.Walking;                              // (If a Knight) sets the knight's state to walking
        if (canSeeTroop == true)
        {
            if (transform.position.x < enemyTroop.transform.position.x)                   // If the Player 2 troop prefab is to the right of the enemy troop, the Player 2 troop should move to the left
            {
                troopRB.velocity = new Vector2(moveSpeed, 0);
            }
            else if (transform.position.x > enemyTroop.transform.position.x)             // If the Player 2 troop prefab is the right of the enemy troop, the Player 2 troop should move to the right
            {
                troopRB.velocity = new Vector2(-moveSpeed, 0);
            }
        }
        Debug.Log("Player 2 Knight is in Walking State");
    }

    public void StopMoveToTroop()
    {
        troopRB.velocity = new Vector2(0, 0);                // Sets the Player 2 troop's velocity to 0. The troop should stop moving
    }
        

}
