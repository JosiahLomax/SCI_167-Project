using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIstateMachine : MonoBehaviour //made by jacklyn
{
    [SerializeField]
    private KnightState knightState;

    [SerializeField]
    private ArcherState archerState;

    [SerializeField]
    private ShielderState shielderState;

    [SerializeField]
    private MageState mageState;

    [SerializeField]
    private GoblinState goblinState;

    [SerializeField]
    private float detectionRange;

    [SerializeField]
    private LayerMask enemyLayer;

    void Start()
    {
        knightState = KnightState.Walking;
        archerState = ArcherState.Walking;
        shielderState = ShielderState.Walking;
        mageState = MageState.Walking;
        goblinState = GoblinState.Walking;
    }

    void Update()
    {
        if (knightState == KnightState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, detectionRange, enemyLayer);
            if (hit.collider != null) //if raycast finds enemy layer (not null/empty), change states
            {
                knightState = KnightState.Attacking;
            }
        }

        if (archerState == ArcherState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, detectionRange, enemyLayer);
            if (hit.collider != null) //if raycast finds enemy layer (not null/empty), change states
            {
                archerState = ArcherState.Shooting;
            }
        }

        if (shielderState == ShielderState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, detectionRange, enemyLayer);
            if (hit.collider != null) //if raycast finds enemy layer (not null/empty), change states
            {
                shielderState = ShielderState.Attacking;
            }
        }

        if (mageState == MageState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, detectionRange, enemyLayer);
            if (hit.collider != null) //if raycast finds enemy layer (not null/empty), change states
            {
                mageState = MageState.Shooting;
            }
        }

        if (goblinState == GoblinState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, detectionRange, enemyLayer);
            if (hit.collider != null) //if raycast finds enemy layer (not null/empty), change states
            {
                goblinState = GoblinState.Attacking;
            }
        }

    }

    public enum KnightState
    {
        Idle,
        Walking,
        Attacking
    };

    public enum ArcherState
    {
        Idle,
        Walking,
        Shooting
    };

    public enum ShielderState
    {
        Idle,
        Walking,
        Attacking
    };

    public enum MageState
    {
        Idle,
        Walking,
        Shooting
    };

    public enum GoblinState
    {
        Idle,
        Walking,
        Attacking
    };
}
