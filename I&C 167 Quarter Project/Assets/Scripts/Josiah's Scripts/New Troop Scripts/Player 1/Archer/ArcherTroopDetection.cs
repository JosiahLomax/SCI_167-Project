using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class ArcherTroopDetection : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D troopRB;                        // A reference to the rigid body component on the Player 1 Archer prefab
    [SerializeField]
    private Transform rayCast;                          // A reference to the raycast object on the Player 1 Archer prefab
    [SerializeField]
    private float agroRange;                           // The range that determines how far the Player 1 Archer can see
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private GameObject enemyTroop;

    private bool canSeeTroop = false;
    private bool facingRight = true;

    public LayerMask enemyTroopLayerP2;                     // enemyTroopLayerP2 is the layer that all player 2 troops should be under

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



    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(rayCast.transform.position, (facingRight ? Vector2.right : Vector2.left) * agroRange);                   // Just creates a line within the editor so the length of the raycast is visible
    }

    void CheckForTroop()
    {
        RaycastHit2D hitTroop = Physics2D.Raycast(rayCast.transform.position, facingRight ? Vector2.right : Vector2.left, agroRange, enemyTroopLayerP2);        // Creates a raycast at the point of the raycast object on the prefab, with the length of the agro range. It looks for anything on the enemyTroopLayerP2 layer
       

        if(hitTroop.collider == true)           // If the raycast successfully hits anything on the enemyTroopLayerP2, it performs the following functions
        {
            Debug.Log("Player 2 Troop Detected!");
            canSeeTroop = true;
            Invoke("MoveToTroop", 1);           // Invoke acts as a timer so that the Player 1 Archer does not immediatley begin moving as soon as it spawns in. It should instead wait 1 sec
           
        }
        else if (hitTroop.collider != true)         // If the raycast does not hit anything on the enemyTroopLayerP2, it performs the following functions
        {
            Debug.Log("Player 2 Troop Not Detected!");
            canSeeTroop = false;
        }
    }

    public void MoveToTroop()
    {
        if(canSeeTroop == true)
        {
            if(transform.position.x < enemyTroop.transform.position.x)              // If the position of the Player 1 Archer prefab is to the left of the enemy troop, the Archer will move to the right
            {
                troopRB.velocity = new Vector2(moveSpeed, 0);
            }
            else if (transform.position.x > enemyTroop.transform.position.x)        // If the position of the Player 1 Archer prefab is to the right of the enemy troop, the Archer will move to the left
            {
                troopRB.velocity = new Vector2(-moveSpeed, 0);
            }
        }
        Debug.Log("Player 1 Moving to Knight!");
    }

    public void StopMoveToTroop()
    {
        troopRB.velocity = new Vector2(0, 0);                                      // Brings the velocity of the Player 1 Archer prefab to 0, meaning it stops moving
    }
    
}
