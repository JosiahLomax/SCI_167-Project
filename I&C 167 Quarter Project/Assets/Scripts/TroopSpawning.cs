using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopSpawning : MonoBehaviour
{
    [SerializeField]
    private GameObject troopToSpawn;            //Takes the prefab of what troop is being spawned

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(troopToSpawn,transform.position,troopToSpawn.transform.rotation);           //After clicking space, the player will spawn in a troop at the position of the troop spawner
        }
    }
}
