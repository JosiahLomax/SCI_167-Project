using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2KnightStateMachine : MonoBehaviour
{
    public KnightState knightState;
    // Above piece of code actually controls and tells us what state the Knight is currently in.

    public float detectionRange = 1;
    // DetectionRange is a variable that identifies the enemy and changes into the attack mode for the sprite.
    // Note: Since this is the Knight the detection Range should be 1 since he only has melee attacks.

    public LayerMask enemyLayer;
    public KnightMovement knightMovement;

    [SerializeField]
    private Animator knightAnimator;



    // Start is called before the first frame update
    void Start()
    {
        //knightState = KnightState.Idle;
        Idle();
    }

    // Update is called once per frame
    void Update()
    {
        new WaitForSeconds(5);
        knightState = KnightState.Walking;
        // The above should put the speed to 0 as a cool down and waiting for the knight to start moving for 5 seconds.

        if (knightState == KnightState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, detectionRange, enemyLayer);
            if (hit.collider != null)
            {
                knightState = KnightState.Swinging;
                knightMovement.enabled = false;
                Swinging(); // Would call the Swinging method below which sets the swinging animation.
            }
            // Now what is happening here is when the knight's Raycast detects and collides with something that is not null, the State changes from Walking to Swinging.

        }

    }

    public void Idle()
    {
        knightState = KnightState.Idle;
        Debug.Log("Knight is in Idle State!");
        //Set the idle animation here. We could do this through the state machince in an animator controller with boolean values.
    }

    public void Swinging()
    {
        // Set swinging animation here. 
        Debug.Log("Knight is in Swinging State!");
    }
}


public enum P2KnightState
{
    Idle,
    Walking,
    Swinging
}
// This will be the 3 main states the knight would be in.

