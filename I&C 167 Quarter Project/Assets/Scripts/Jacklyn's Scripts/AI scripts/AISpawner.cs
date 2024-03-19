using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject AImagePrefab;

    [SerializeField]
    private GameObject AIKnightPrefab;

    [SerializeField]
    private GameObject AIShielderPrefab;

    


    
    void Start()
    {
        Instantiate(AImagePrefab, transform.position, Quaternion.identity);
        Instantiate(AIKnightPrefab, transform.position, Quaternion.identity);
        Instantiate(AIKnightPrefab, transform.position, Quaternion.identity);
        Instantiate(AIShielderPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
