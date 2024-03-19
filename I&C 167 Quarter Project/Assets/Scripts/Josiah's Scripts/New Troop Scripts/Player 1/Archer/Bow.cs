using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Code Written by Josiah Lomax
public class Bow : MonoBehaviour
{
    public GameObject arrowPrefab;              // References Player 1 arrow prefab
    public float coolDown = 2.5f;               // Cooldown for shooting
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(arrowPrefab, transform.position, Quaternion.identity);          // Spawns in the Player 1 arrow prefab at the position of the bow with the arrow's original rotation.
            timer = coolDown;
        }
    }
}
