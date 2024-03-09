using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Code Written by Josiah Lomax
public class TroopDetection : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D troopRB;
    [SerializeField]
    private Transform rayCast;
    [SerializeField]
    private float agroRange;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private GameObject enemyTroop;
   

    private bool canSeeTroop = false;
    private bool facingRight = true;

    public LayerMask enemyTroopLayerP2;

    public KnightState knightState;

    


   

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
        Gizmos.DrawRay(rayCast.transform.position, (facingRight ? Vector2.right : Vector2.left) * agroRange);
    }
    
    void CheckForTroop()
    {
        RaycastHit2D hitTroop = Physics2D.Raycast(rayCast.transform.position, facingRight ? Vector2.right : Vector2.left, agroRange, enemyTroopLayerP2);

        if (hitTroop.collider == true)
        {
            canSeeTroop = true;
             Debug.Log("Enemy Troop Detected!");
             StartCoroutine(TroopDetected());
            
        }
        else if(hitTroop.collider != true)
        {
            canSeeTroop = false;
            StopMoveToTroop();
        }
    }

    IEnumerator TroopDetected()
    {
        if (canSeeTroop == true)
        {
            yield return new WaitForSeconds(1);
            knightState = KnightState.Walking;
            Debug.Log("Knight is in the Walking State!");
            MoveToTroop();
        }
    }

    public void MoveToTroop()
    {
        if (transform.position.x > enemyTroop.transform.position.x)
        {
            troopRB.velocity = new Vector2(moveSpeed, 0);
        }
        else if (transform.position.x < enemyTroop.transform.position.x)
        {
            troopRB.velocity = new Vector2(-moveSpeed, 0);
        }
    }

   public void StopMoveToTroop()
    {
        troopRB.velocity = new Vector2(0, 0);
    }

}
