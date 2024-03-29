using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Code Written by Josiah Lomax
public class Player2Control : MonoBehaviour
{
    [SerializeField]
    private GameObject troopSpawnPoint;                                             // Troop Spawn Point for Player 2

    [SerializeField]
    private GameObject knightToSpawn;                                              // Player 2 Knight Gameobject
    [SerializeField]
    private GameObject archerToSpawn;                                             // Player 2 Archer Gameobject
    [SerializeField]
    private GameObject goblinToSpawn;                                             // Player 2 Goblin Gameobject
    [SerializeField]
    private GameObject mageToSpawn;                                              // Player 2 Mage Gameobject
    [SerializeField]
    private GameObject shielderToSpawn;                                         // Player 2 Shielder Gameobject



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Instantiate(knightToSpawn, troopSpawnPoint.transform.position, knightToSpawn.transform.rotation);       // Pressing 0 on the Keyboard will Spawn Knight!
        }

        if(Input.GetKeyDown(KeyCode.Alpha8))
        {
            Instantiate(archerToSpawn, troopSpawnPoint.transform.position, archerToSpawn.transform.rotation);     // Pressing 9 on the Keyboad will Spawn Archer!
        }

        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            Instantiate(goblinToSpawn, troopSpawnPoint.transform.position, goblinToSpawn.transform.rotation);   // Pressing 8 on the Keyboard will Spawn Goblin!
        }

        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            Instantiate(mageToSpawn, troopSpawnPoint.transform.position, mageToSpawn.transform.rotation);       // Pressing 7 on the Keyboard will Spawn Mage!
        }

        if(Input.GetKeyDown(KeyCode.Alpha7))
        {
            Instantiate(shielderToSpawn, troopSpawnPoint.transform.position, shielderToSpawn.transform.rotation);       // Pressing 6 on the Keyboard will Spawn Shielder!
        }
    }
}
