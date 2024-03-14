using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Control : MonoBehaviour
{
    [SerializeField]
    private GameObject troopSpawnPoint;                             // The Point where the Troops will be Spawned

    [SerializeField]
    private GameObject KnightToSpawn;                              // Knight Gameobject
    [SerializeField]
    private GameObject ArcherToSpawn;                             // Archer Gameobject


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(KnightToSpawn, troopSpawnPoint.transform.position, KnightToSpawn.transform.rotation);           // Pressing 1 on the Keyboard Spawns in Knight
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(ArcherToSpawn, troopSpawnPoint.transform.position, ArcherToSpawn.transform.rotation);          // Pressing 2 on the Keyoard Spawns in Archer 
        }
    }
}
