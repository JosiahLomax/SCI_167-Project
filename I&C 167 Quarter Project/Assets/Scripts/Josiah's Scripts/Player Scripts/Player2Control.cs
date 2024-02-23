using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Control : MonoBehaviour
{
    [SerializeField]
    private GameObject troopSpawnPoint;

    [SerializeField]
    private GameObject troopToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(troopToSpawn, troopSpawnPoint.transform.position, troopToSpawn.transform.rotation);
        }
    }
}
