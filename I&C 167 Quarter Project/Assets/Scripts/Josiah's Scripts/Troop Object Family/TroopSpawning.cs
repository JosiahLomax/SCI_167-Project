using System.Collections;
using System.Collections.Generic;
using UnityEngine;
        
public class TroopSpawning : MonoBehaviour                                                      // Code written by Josiah Lomax                               
{   
    [SerializeField]
    private GameObject troopToSpawn;                                                             // Takes the prefab of the troop prototype that is being spawned

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(troopToSpawn,transform.position,troopToSpawn.transform.rotation);           // After clicking spacebar, the player will spawn in a troop prototype at the position of the troop spawner
        }
      
    }
}
