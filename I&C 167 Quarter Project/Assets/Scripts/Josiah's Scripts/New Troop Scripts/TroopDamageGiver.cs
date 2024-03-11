using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopDamageGiver : MonoBehaviour
{

    [SerializeField]
    private int Damage;
    [SerializeField]
    private GameObject parentPrefab;

    protected virtual void TakeDamage(TroopHealth troop)
    {
        troop.TakeDamage(Damage);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Troop")
        {
            TroopHealth troop = collision.gameObject.GetComponent<TroopHealth>();
            TakeDamage(troop);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
