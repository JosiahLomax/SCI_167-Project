using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour                                     // Code written by Josiah Lomax
{

    [SerializeField]
    private Transform rayCast;

    [SerializeField]
    private float agroRange;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
     private GameObject targetPlayer;

   // [SerializeField]
    //private GameObject targetTroop;
  
    private Rigidbody2D knightRigidBody;

    private bool isFacingLeft;

    private bool isAgro = false;




   
    // Start is called before the first frame update
    void Start()
    {
        knightRigidBody = GetComponent<Rigidbody2D>();                                                             // This script will be attatched to the Knight prefab
                                                                      // Will likely assign the data from the Knight scriptable object
    }

    // Update is called once per frame
    void Update()
    {
      
      
         if(CanSeePlayer(agroRange))
        {
            isAgro = true;
            Invoke("MoveToPlayerTarget", 2);           // Agro Troop
        
        }
        else
        {
            StopMoveToPlayerTarget();
        }
      
    }

    bool CanSeePlayer(float distance)
    {
        bool val = false;
        float castDist = distance;

        if(isFacingLeft == true)
        {
            castDist = -distance;
        }

        Vector2 endPos = rayCast.position + Vector3.right * castDist;
        
        RaycastHit2D hit = Physics2D.Linecast(rayCast.position, endPos, 1 << LayerMask.NameToLayer("Action"));

        if(hit.collider != null)
        {
            if(hit.collider.gameObject.CompareTag("Player"))
            {
                val = true;
            }
            else
            {
                val = false;
            }
            Debug.DrawLine(rayCast.position, hit.point, Color.green);
        }
        else
        {
            Debug.DrawLine(rayCast.position, endPos, Color.red);
        }

        return val;
    }

    

    void MoveToPlayerTarget()
    {
        if(transform.position.x < targetPlayer.transform.position.x)
        {
            knightRigidBody.velocity = new Vector2(moveSpeed, 0);              // Troop is to the left side of the player, so move right
            //transform.localScale = new Vector2(1, 1);
            isFacingLeft = false;
        }
        else if (transform.position.x > targetPlayer.transform.position.x)
        {
            knightRigidBody.velocity = new Vector2(-moveSpeed, 0);           // Troop is to the right side of the player, so move left
            //transform.localScale = new Vector2(-1, 1);
            isFacingLeft = true;
        }
    }

    void StopMoveToPlayerTarget()
    {
        isAgro = false;
        knightRigidBody.velocity = new Vector2(0, 0);
    }

    
}


/*
        float distToPlayer = Vector2.Distance(transform.position, targetPlayer.transform.position);
        Debug.Log("distToPlayer:" + distToPlayer);

        if(distToPlayer < agroRange)                // Distance check I could rework later into check for troops!
        {
            //Code to chase player
            MoveToPlayerTarget();
        }
        else
        {
            //Stop chasing player
            StopMoveToPlayerTarget();
        }
      */