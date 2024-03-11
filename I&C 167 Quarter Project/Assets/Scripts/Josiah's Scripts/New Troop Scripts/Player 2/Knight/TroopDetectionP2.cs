using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class TroopDetectionP2 : MonoBehaviour
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
    private bool facingLeft = true;

    public LayerMask enemyTroopLayerP1;
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


    void CheckForTroop()
    {
        RaycastHit2D hitTroop = Physics2D.Raycast(rayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, agroRange, enemyTroopLayerP1);

        if(hitTroop.collider == true)
        {
            Debug.Log("Player 1 Troop Detected!");
            canSeeTroop = true;
            MoveToTroop();
        }
        else if(hitTroop.collider != true)
        {
            Debug.Log("Player 1 Troop Not Detected!");
            canSeeTroop = false;
        }
    }

    public void MoveToTroop()
    {
        if (canSeeTroop == true)
        {
            if (transform.position.x < enemyTroop.transform.position.x)
            {
                troopRB.velocity = new Vector2(moveSpeed, 0);
            }
            else if (transform.position.x > enemyTroop.transform.position.x)
            {
                troopRB.velocity = new Vector2(-moveSpeed, 0);
            }
        }
    }

    public void StopMoveToTroop()
    {
        troopRB.velocity = new Vector2(0, 0);
    }
        

}
