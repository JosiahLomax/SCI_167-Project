using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private bool facingRight = true;
    private Transform enemyPlayerPos;

    
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

    void CheckForPlayer()
    {
        RaycastHit2D hitPlayer = Physics2D.Raycast(rayCast.transform.position, facingRight ? Vector2.right : Vector2.left, agroRange, enemyPlayer2Layer);

        if (hitPlayer.collider == true)
        {
            StartCoroutine(PlayerDetected()); 
        }
       
    }

    IEnumerator PlayerDetected()
    {
        Debug.Log("Player Detected");
        yield return new WaitForSeconds(1);
    }

    void CheckForTroop()
    {
        RaycastHit2D hitTroop = Physics2D.Raycast(rayCast.transform.position, facingRight ? Vector2.right : Vector2.left, agroRange, enemyTroopLayerP2);

        if (hitTroop.collider == true)
        {
            StartCoroutine(TroopDetected());
        }
    }

    IEnumerator TroopDetected()
    {
        Debug.Log("Troop Detected!");
        yield return new WaitForSeconds(1);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(rayCast.transform.position, (facingRight ? Vector2.right : Vector2.left) * agroRange);
    }



    void MoveToPlayer()
    {
       
    }

    void MoveToTroop()
    {

    }
}
