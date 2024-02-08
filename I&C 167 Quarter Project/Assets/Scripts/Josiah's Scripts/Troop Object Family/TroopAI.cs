using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class TroopAI : MonoBehaviour                                        // Code written by Josiah Lomax
{
    public Transform target;                                                // Takes the transform position of the object that will be the target of movement
    

    public float speed;                                                     // The speed in which the troop gameobject travels towards the target
    public float nextWaypointDistance;                                      // The distance from the current waypoint the troop gameobject is at to the next waypoint it is moving to

    Path path;                                                              // The path that is drawn using A*
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;                                          // A boolean checking if the object has reached the end of the drawn path or not

    Seeker seeker;                                                          // References the Seeker script on the troop gameobject
    Rigidbody2D rb;                                                         // References the rigidbody2D attached to the troop gameobject

    // Start is called before the first frame update
    void Start()
    { 
        seeker = GetComponent<Seeker>();                                  // Gets the Seeker component from the troop gameobject
        rb = GetComponent<Rigidbody2D>();                                 // Gets the Rigidbody2D from the troop gameobject

        InvokeRepeating("UpdatePath", 0f, .5f);                           // Updates the path repeatedly
    }

    void UpdatePath()
    {
        if(seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete);    // If the troop gameobject has reached the target at the end of the path, the path is complete
    }

    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0;                                    // When the path is completed, the path is finished being drawn
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (path == null)
            return;

        if(currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;                            // Sets the reachedEndOfPath boolean to true if the current waypoint has a value greater than the end of the path count
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;               // The direction in which the troop gameobject moves to follow the path
        Vector2 force = direction * speed * Time.deltaTime;                                                     // The force that is applies to the troop gameobject to facilitate movement

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);                       // Sets the distance from the troop gameobject's rigidbody to the current waypoint

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;                                                                                  // If the distance is less than the distance to the next way point, the current waypooint is increased
        }
    }
}
