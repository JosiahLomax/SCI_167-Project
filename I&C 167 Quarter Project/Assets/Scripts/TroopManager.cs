using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopManager : MonoBehaviour
{
    [SerializeField]
     private SOTroopDefinition troopDefinition;
    [SerializeField]
    private GameObject troopToSpawn;   //Takes the prefab of what troop is being spawned

    public GameObject enemyPlayer;     //Takes the prefab of what player the troop will move towards
    public float speed;

  

  

    // Start is called before the first frame update
    void Start()
    {
        troopDefinition = GetComponent<SOTroopDefinition>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawnedTroop = Instantiate(troopToSpawn, transform.position, Quaternion.identity);
            Vector3 direction = enemyPlayer.transform.transform.position - spawnedTroop.transform.position;
            spawnedTroop.GetComponent<Rigidbody2D>().velocity = direction * speed;

        }
    }
}
