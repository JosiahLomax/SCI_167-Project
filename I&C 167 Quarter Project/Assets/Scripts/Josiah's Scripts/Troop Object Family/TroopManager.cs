using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopManager : MonoBehaviour                        // Code witten by Josiah Lomax
{                                                               // Class will be responsible for being the overarching manager for the troop family of objects
    [SerializeField]
     private SOTroopDefinition troopDefinition;               // Creates a field within the Unity editor to plug in a specific troop family of objects
    
    // Start is called before the first frame update
    void Start()
    {
                                                             // This script will be likley be made into a factory that produces a generic troop instance
                                                            // Will call the troopInstance script
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
