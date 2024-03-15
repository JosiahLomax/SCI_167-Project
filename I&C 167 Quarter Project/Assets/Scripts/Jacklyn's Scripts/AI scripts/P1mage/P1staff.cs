using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1staff : MonoBehaviour // made by jacklyn
{
    [SerializeField]
    private GameObject P1staffPrefab;

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
            Instantiate(P1staffPrefab, transform.position, Quaternion.identity);
            timer = coolDown;
        }

    }

}
