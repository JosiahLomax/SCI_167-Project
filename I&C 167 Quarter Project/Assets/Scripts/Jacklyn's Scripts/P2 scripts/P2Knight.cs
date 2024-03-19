using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CODED BY JACKLYN
// child class inherits from P2Troops
public class P2Knight : P2Troops      //code by jacklyn and josiah
{
    //public Rigidbody2D P2KnightRb;
    //public float movementSpeed;


    [SerializeField]
    private Rigidbody2D P2KnightRB;
    [SerializeField]
    private Transform rayCast;
    [SerializeField]
    private float agroRange;
    [SerializeField]
    private float movementSpeed;

    private bool facingLeft = true;
    private Transform enemyPlayerPos;


    public LayerMask enemyPlayer1Layer, enemyTroopLayerP1;

    // Start is called before the first frame update
    void Start()
    {
        P2KnightRB.velocity = Vector2.left * movementSpeed;
        P2KnightRB = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        CheckForPlayer();
        CheckForTroop();
    }

    void CheckForPlayer()
    {
        RaycastHit2D hitPlayer = Physics2D.Raycast(rayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, agroRange, enemyPlayer1Layer);

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
        RaycastHit2D hitTroop = Physics2D.Raycast(rayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, agroRange, enemyTroopLayerP1);

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
        Gizmos.DrawRay(rayCast.transform.position, (facingLeft ? Vector2.left : Vector2.right) * agroRange);
    }



    void MoveToPlayer()
    {

    }

    void MoveToTroop()
    {

    }



    protected override void P2MoveTowardTarget()
    {
        P2KnightRB.velocity = Vector2.left * movementSpeed;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Player player = collision.gameObject.GetComponent<Player>();
    //        ApplyDamage(player, damage); // Apply damage with a specific amount
    //        Destroy(this.gameObject);   // Destroy the object that collided with the player
    //    }
    //}


}
