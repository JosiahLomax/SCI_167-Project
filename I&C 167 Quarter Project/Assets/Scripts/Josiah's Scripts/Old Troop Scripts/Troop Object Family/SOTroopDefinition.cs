using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "CastleSeige/TroopDefinition")]         // Creates a menu item for the scriptable object witin Unity
public class SOTroopDefinition : ScriptableObject                   // Code written by Josiah Lomax
{

    public enum TroopType                                          // A list of the different troop types available to the player
    {
        ARCHER,
        SHIELDER,
        KNIGHT,
        GOBLIN,
        MAGE
    }

    [SerializeField]
    private GameObject troopPrefab;                            // Creates a field within the Unity editor in which we can plug in the specific troop prefab we need
    [SerializeField]
    private string displayName;                               // The name that will appear in the UI for the specfic troop type
    [SerializeField]
    public float troopHealth;                                // The amount of health the specific troop type will have
    [SerializeField]
    public float movementSpeed;                             // How fast a specific troop type moves
    [SerializeField]
    private float damagePerAttack;                         // How much damage each attack from a troop type does
    [SerializeField]
    private TroopType type;                               // Will allow the troop type to be specificed wihtin the scriptable object in the editor
    
    
   
    public string GetName()         
    {
        return displayName;                            // Gets the name that is assigned for the specifc troop type within the editor
    }

    public float GetTroopHealth()
    {
        return troopHealth;                          // Gets the health that is assigned for the specific troop type within the editor
    }
   
}
