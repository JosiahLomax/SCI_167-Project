using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIbow : MonoBehaviour
{
    [SerializeField]
    private GameObject AIarrowPrefab;

    [SerializeField]
    private float coolDown = 2.5f;

    [SerializeField]
    private float timer;

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
            Instantiate(AIarrowPrefab, transform.position, Quaternion.identity);
            timer = coolDown;
        }

    }
}
