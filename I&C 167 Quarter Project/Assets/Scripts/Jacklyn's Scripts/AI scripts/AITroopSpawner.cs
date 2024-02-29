using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITroopSpawner : MonoBehaviour
{
    public GameObject AIknightPrefab;
    public GameObject AIarcherPrefab;
    public void Start()
    {
        /* level 1 AI player has 3 knights and 2 archers spawning??
         maybe we add more levels? */

        SpawnAIKnight();
        SpawnAIArcher();
        
    }

    public void SpawnAIKnight()
    {

    }
}
