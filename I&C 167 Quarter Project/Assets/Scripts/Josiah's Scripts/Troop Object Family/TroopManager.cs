using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopManager : MonoBehaviour
{
    [SerializeField]
     private SOTroopDefinition troopDefinition;
    
    // Start is called before the first frame update
    void Start()
    {
        troopDefinition = GetComponent<SOTroopDefinition>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
