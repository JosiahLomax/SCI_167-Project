using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class Staff : MonoBehaviour
{
    public GameObject spellPrefab;
    public float coolDown = 2.5f;
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
        if(timer <= 0)
        {
            Instantiate(spellPrefab, transform.position, Quaternion.identity);
            timer = coolDown;
        }
    }
}
