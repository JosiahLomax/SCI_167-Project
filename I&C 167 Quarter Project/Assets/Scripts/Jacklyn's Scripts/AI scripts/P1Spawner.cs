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
            //Instantiate(P1mage, P1spawnPoint.transform.position, P1mage.transform.rotation);
            SpawnMage();
        }
    }

    public void SpawnMage()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        Instantiate(P1mage, P1spawnPoint.position, Quaternion.identity);
        //}

       

    }
    public void SpawnGoblin()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(P1goblin, P1spawnPoint.position, Quaternion.identity);
        }
    }
    public void SpawnArcher()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(P1archer, P1spawnPoint.position, Quaternion.identity);
        }
    }
    public void SpawnShielder()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Instantiate(P1shielder, P1spawnPoint.position, Quaternion.identity);
        }
    }
    public void SpawnKnight()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Instantiate(P1knight, P1spawnPoint.position, Quaternion.identity);
        }
    }
}
