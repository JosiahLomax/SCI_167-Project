using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Spawner : MonoBehaviour // made by jacklyn
{
    [SerializeField]
    private GameObject P1mage;

    [SerializeField]
    private GameObject P1goblin;

    [SerializeField]
    private GameObject P1archer;

    [SerializeField]
    private GameObject P1shielder;

    [SerializeField]
    private GameObject P1knight;

    [SerializeField]
    private Transform P1spawnPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnMage();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpawnGoblin();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SpawnArcher();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SpawnShielder();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SpawnKnight();
        }
    }

    public void SpawnMage()
    {
        Instantiate(P1mage, P1spawnPoint.position, Quaternion.identity);
    }
    public void SpawnGoblin()
    {
        Instantiate(P1goblin, P1spawnPoint.position, Quaternion.identity);
    }
    public void SpawnArcher()
    {   
       Instantiate(P1archer, P1spawnPoint.position, Quaternion.identity);  
    }
    public void SpawnShielder()
    {       
        Instantiate(P1shielder, P1spawnPoint.position, Quaternion.identity); 
    }
    public void SpawnKnight()
    {        
        Instantiate(P1knight, P1spawnPoint.position, Quaternion.identity);        
    }
}
