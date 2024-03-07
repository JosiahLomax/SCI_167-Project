using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Control : MonoBehaviour
{
    [SerializeField]
    private GameObject troopSpawnPoint;

    [SerializeField]
    private GameObject KnightToSpawn;
    [SerializeField]
    private GameObject ArcherToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(KnightToSpawn, troopSpawnPoint.transform.position, KnightToSpawn.transform.rotation);           // After clicking spacebar, the player will spawn in a troop prototype at the position of the troop spawner
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(ArcherToSpawn, troopSpawnPoint.transform.position, ArcherToSpawn.transform.rotation);
        }
    }
}
